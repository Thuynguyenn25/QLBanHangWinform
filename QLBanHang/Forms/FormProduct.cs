using QLBanHang.BLL;
using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class FormProduct : Form
    {
        private bool _isAddMode = true;
        private bool _suppressCategoryChanged = false;

        private readonly ProductBLL _productBLL = new ProductBLL();
        private readonly CategoryBLL _categoryBLL = new CategoryBLL();

        public FormProduct()
        {
            InitializeComponent();
            this.Shown += FormProduct_Shown;
        }
        private void FormProduct_Shown(object sender, EventArgs e)
        {
            dgvProduct.ClearSelection();
            dgvProduct.CurrentCell = null;
        }


        public void LoadProduct()
        {
            dgvProduct.Rows.Clear();

            var products = _productBLL.GetAll();

            foreach (var p in products)
            {
                string isActiveText = p.IsActive == 1 ? "Đang bán" : "Ngừng bán";
                string priceText = p.Price.ToString("#,##0");

                dgvProduct.Rows.Add(
                    false,
                    p.ProductID,
                    p.Name,
                    priceText,
                    p.Stock,
                    isActiveText,
                    p.CategoryID
                );
            }
            SetButtonState(false);
            // lblTotalActive.Text = $"Đang bán: {_productBLL.CountActive()}";
        }


        public void LoadCategories()
        {
            DataTable dt = _categoryBLL.GetAllForComboBox();

            _suppressCategoryChanged = true;
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedIndex = 0;
            _suppressCategoryChanged = false;
        }


        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategories();
            EnterAddMode();
        }

        public bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtIDProduct.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hàng");
                return false;
            }

            if (!int.TryParse(txtIDProduct.Text.Trim(), out _))
            {
                int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
                txtIDProduct.Text = _productBLL.GenerateProductID(categoryId);
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hàng");
                return false;
            }

            if (cboCategory.SelectedIndex == -1 || cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục");
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price < 0)
            {
                MessageBox.Show("Price không hợp lệ!");
                return false;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out int stock) || stock < 0)
            {
                MessageBox.Show("Stock không hợp lệ!");
                return false;
            }

            return true;
        }

        private void SetButtonState(bool isEditing)
        {
            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = isEditing;
            btnDelete.Enabled = isEditing;
            txtIDProduct.Enabled = !isEditing;
        }

        private void EnterAddMode()
        {
            _isAddMode = true;
            SetButtonState(false);
            if (cboCategory.SelectedValue != null)
            {
                int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
                txtIDProduct.Text = _productBLL.GenerateProductID(categoryId);
            }
        }

        private void EnterEditMode()
        {
            _isAddMode = false;
            SetButtonState(true);
        }

        public void Clear()
        {
            txtIDProduct.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            chkIsActive.Checked = true;
            SetButtonState(false);

            dgvProduct.ClearSelection();
            dgvProduct.CurrentCell = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            EnterAddMode();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _isAddMode = true;
                if (!ValidateInput()) return;

                int categoryID = Convert.ToInt32(cboCategory.SelectedValue);
                string productID = _productBLL.GenerateProductID(categoryID);
                txtIDProduct.Text = productID;

                var product = new ProductDTO
                {
                    ProductID = productID,
                    Name = txtName.Text.Trim(),
                    CategoryID = categoryID,
                    Price = decimal.Parse(txtPrice.Text.Replace(",", "")),
                    Stock = int.Parse(txtStock.Text.Trim()),
                    IsActive = chkIsActive.Checked ? 1 : 0
                };

                var (success, message) = _productBLL.Add(product);
                MessageBox.Show(message);

                if (!success && message.Contains("tồn tại"))
                {
                    txtIDProduct.Text = _productBLL.GenerateProductID(categoryID);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Add Product: ", ex);
            }
            LoadProduct();
            Clear();
            EnterAddMode();
        }


        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                EnterEditMode();
                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

                txtIDProduct.Text = row.Cells["cIDProduct"].Value?.ToString() ?? "";
                txtName.Text = row.Cells["cName"].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells["cPrice"].Value?.ToString() ?? "";
                txtStock.Text = row.Cells["cStock"].Value?.ToString() ?? "";

                if (row.Cells["cCategoryID"].Value != null)
                    cboCategory.SelectedValue = Convert.ToInt32(row.Cells["cCategoryID"].Value);
                else
                    cboCategory.SelectedIndex = -1;

                int isActive = (row.Cells["cIsActive"].Value?.ToString() == "Đang bán") ? 1 : 0;
                chkIsActive.Checked = (isActive == 1);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                _isAddMode = false;
                if (!ValidateInput()) return;

                var product = new ProductDTO
                {
                    ProductID = txtIDProduct.Text.Trim(),
                    Name = txtName.Text.Trim(),
                    CategoryID = Convert.ToInt32(cboCategory.SelectedValue),
                    Price = decimal.Parse(txtPrice.Text.Replace(",", "")),
                    Stock = int.Parse(txtStock.Text.Trim()),
                    IsActive = chkIsActive.Checked ? 1 : 0
                };

                var (success, message) = _productBLL.Update(product);
                MessageBox.Show(message);
                LoadProduct();
                Clear();
                EnterAddMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Update Product: ", ex);
            }
            LoadProduct();
            Clear();
            EnterAddMode();
        }

        public void SearchProduct()
        {
            string keyword = txtSearch.Text.Trim();
            dgvProduct.Rows.Clear();

            var products = _productBLL.Search(keyword);

            foreach (var p in products)
            {
                dgvProduct.Rows.Add(
                    false,
                    p.ProductID,
                    p.Name,
                    p.Price,
                    p.Stock,
                    p.IsActive,
                    p.CategoryID
                );
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm");
                return;
            }
            SearchProduct();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadProduct();
            }
            else
            {
                SearchProduct();
            }
        }
        //------------------------------------------------

        private void dgvProduct_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvProduct.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0)
            {
                dgvProduct.ClearSelection();
                dgvProduct.CurrentCell = null;
                return;
            }
            if (!dgvProduct.Rows[hit.RowIndex].Selected)
            {
                dgvProduct.ClearSelection();
                dgvProduct.Rows[hit.RowIndex].Selected = true;
                int colIndex = hit.ColumnIndex >= 0 ? hit.ColumnIndex : 1;
                dgvProduct.CurrentCell = dgvProduct.Rows[hit.RowIndex].Cells[colIndex];
            }
        }

        private void tsmiSelectItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.SelectedRows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void tsmiUnselect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            var checkedIds = new List<string>();
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                bool isCheck = row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value);
                if (isCheck)
                {
                    string id = row.Cells["cIDProduct"].Value?.ToString() ?? "";
                    if (!string.IsNullOrWhiteSpace(id))
                        checkedIds.Add(id);
                }
            }

            if (checkedIds.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn để xóa! ");
                return;
            }
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa {checkedIds.Count} sản phẩm đã chọn không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            var (deleted, disabled) = _productBLL.DeleteMultiple(checkedIds);
            MessageBox.Show($"Xong!\nĐã xóa: {deleted}\nĐã chuyển Ngừng bán: {disabled}");
            LoadProduct();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Enabled)
            {
                string idProduct = txtIDProduct.Text;

                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm số {idProduct} không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                var (success, message) = _productBLL.Delete(idProduct);
                MessageBox.Show(message);
                LoadProduct();
                Clear();
                EnterAddMode();
            }
        }
        //----------------------

        private void dgvProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

            if (row.Cells["cStock"].Value == null) return;

            if (int.TryParse(row.Cells["cStock"].Value.ToString(), out int stock))
            {
                if (stock < 5)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;   
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;    
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        //--------------------

        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV file (*.csv)|*.csv";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

                    if (lines.Length <= 1)
                    {
                        MessageBox.Show("File CSV trống hoặc không đúng định dạng!");
                        return;
                    }

                    var products = new List<ProductDTO>();
                    int skippedParse = 0;

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();
                        if (string.IsNullOrWhiteSpace(line)) { skippedParse++; continue; }

                        string[] parts = line.Split(',');
                        if (parts.Length < 6) { skippedParse++; continue; }

                        string productId = parts[0].Trim();
                        if (string.IsNullOrWhiteSpace(productId) || productId.Contains(",")) { skippedParse++; continue; }

                        string name = parts[1].Trim();
                        if (string.IsNullOrWhiteSpace(name)) { skippedParse++; continue; }

                        if (!int.TryParse(parts[2].Trim(), out int categoryId)) { skippedParse++; continue; }

                        string priceText = parts[3].Trim().Replace(",", "");
                        if (!decimal.TryParse(priceText, out decimal price) || price < 0) { skippedParse++; continue; }

                        if (!int.TryParse(parts[4].Trim(), out int stock) || stock < 0) { skippedParse++; continue; }

                        if (!int.TryParse(parts[5].Trim(), out int isActive)) { skippedParse++; continue; }
                        isActive = (isActive == 1) ? 1 : 0;

                        products.Add(new ProductDTO
                        {
                            ProductID = productId,
                            Name = name,
                            CategoryID = categoryId,
                            Price = price,
                            Stock = stock,
                            IsActive = isActive
                        });
                    }

                    var (inserted, updated, skipped) = _productBLL.ImportProducts(products);
                    skipped += skippedParse;

                    MessageBox.Show($"Import xong!\nThêm mới: {inserted}\nCập nhật: {updated}\nBỏ qua: {skipped}");
                    LoadProduct();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import thất bại: " + ex.Message);
                    Utils.Log("Import CSV: ", ex);
                }
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressCategoryChanged) return;
            if (!_isAddMode) return;
            if (cboCategory.SelectedItem == null) return;

            var drv = cboCategory.SelectedItem as DataRowView;
            if (drv == null) return;

            int categoryId = Convert.ToInt32(drv["CategoryID"]);
            txtIDProduct.Text = _productBLL.GenerateProductID(categoryId);
        }
    }
}
