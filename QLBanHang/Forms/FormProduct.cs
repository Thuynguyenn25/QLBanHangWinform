using QLBanHang.Data;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            this.Shown += FormProduct_Shown;
            txtPrice.Leave += txtPrice_Leave;
        }
        private void FormProduct_Shown(object sender, EventArgs e)
        {
            dgvProduct.ClearSelection();
            dgvProduct.CurrentCell = null;
        }


        public void LoadProduct()
        {
            dgvProduct.Rows.Clear();

            string query = "SELECT * FROM Products ";
            SQLiteUtils sQL = new SQLiteUtils();
            DataTable dt = sQL.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                int isActiveValue = Convert.ToInt32(dr["IsActive"]);
                string isActiveText = isActiveValue == 1 ? "Đang bán" : "Ngừng bán";

                decimal price = Convert.ToDecimal(dr["Price"]);
                string priceText = price.ToString("#,##0");

                dgvProduct.Rows.Add(
                    false,
                    dr["ProductID"],
                    dr["Name"],
                    priceText,
                    dr["Stock"],
                    isActiveText,
                    dr["CategoryID"]
                    );
            }
            SetButtonState(false);

        }
        public void LoadCategories()
        {
            string queryCate = "SELECT CategoryID, Name FROM Categories ORDER BY Name";
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(queryCate);

            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedIndex = -1;
        }


        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCategories();
            SetButtonState(false);

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
                MessageBox.Show("Mã hàng phải là số!");
                return false;
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

            string priceText = txtPrice.Text.Replace(",", "").Trim();
            if (!decimal.TryParse(priceText, out decimal price) || price < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                txtPrice.Focus();
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
        public void Clear()
        {
            txtIDProduct.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            chkIsActive.Checked = !chkIsActive.Checked;
            SetButtonState(false);

            dgvProduct.ClearSelection();
            dgvProduct.CurrentCell = null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                int productID = int.Parse(txtIDProduct.Text.Trim());
                string name = txtName.Text.Trim();
                decimal price = decimal.Parse(txtPrice.Text.Replace(",", ""));
                int stock = int.Parse(txtStock.Text.Trim());

                int categoryID = Convert.ToInt32(cboCategory.SelectedValue);

                int isActive = chkIsActive.Checked ? 1 : 0;

                string query = $"INSERT INTO Products(ProductID, Name, CategoryID, Price, Stock, IsActive) " +
                    $"VALUES('{productID}', '{name}', '{categoryID}', '{price}', '{stock}', '{isActive}')";
                SQLiteUtils sQL = new SQLiteUtils();

                sQL.ExecuteQuery(query);
                MessageBox.Show("Đã thêm sản phẩm thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Add Product: ", ex);
            }
            LoadProduct();
            Clear();
        }


        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

                txtIDProduct.Text = row.Cells["cIDProduct"].Value?.ToString() ?? "";
                txtName.Text = row.Cells["cName"].Value?.ToString() ?? "";
                string p = row.Cells["cPrice"].Value?.ToString() ?? "0";
                if (decimal.TryParse(p.Replace(",", ""), out decimal pr))
                    txtPrice.Text = pr.ToString("#,##0");
                else
                    txtPrice.Text = p;

                txtStock.Text = row.Cells["cStock"].Value?.ToString() ?? "";

                if (row.Cells["cCategoryID"].Value != null)
                    cboCategory.SelectedValue = Convert.ToInt32(row.Cells["cCategoryID"].Value);
                else
                    cboCategory.SelectedIndex = -1;

                int isActive = (row.Cells["cIsActive"].Value?.ToString() == "Đang bán") ? 1 : 0;
                chkIsActive.Checked = (isActive == 1);

                SetButtonState(true);

            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                int productID = int.Parse(txtIDProduct.Text);

                string name = txtName.Text;
                decimal price = decimal.Parse(txtPrice.Text.Replace(",", ""));
                int stock = int.Parse(txtStock.Text);
                int categoryID = Convert.ToInt32(cboCategory.SelectedValue);
                int isActive = chkIsActive.Checked ? 1 : 0;

                string query = $"UPDATE Products SET Name='{name}', CategoryID ='{categoryID}', Price = '{price}',Stock ='{stock}', IsActive = '{isActive}' WHERE ProductID ='{productID}' ";
                SQLiteUtils sQL = new SQLiteUtils();
                sQL.ExecuteQuery(query);

                MessageBox.Show("Đã sửa thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Update Product: ", ex);
            }
            LoadProduct();
            Clear();
        }

        //----------------
        public void SearchProduct()
        {
            string keyword = txtSearch.Text.Trim();
            string kw = "%" + keyword + "%";
            dgvProduct.Rows.Clear();

            string query = $@"SELECT * FROM Products
                                WHERE name LIKE '{kw}'";
            SQLiteUtils sQL = new SQLiteUtils();
            DataTable dt = sQL.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                dgvProduct.Rows.Add(
                    false,
                    dr["ProductID"],
                    dr["Name"],
                    dr["Price"],
                    dr["Stock"],
                    dr["IsActive"],
                    dr["CategoryID"]
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
            int countChecked = 0;
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                bool isCheck = row.Cells[0].Value != null &&
                    Convert.ToBoolean(row.Cells[0].Value);
                if (isCheck) countChecked++;
            }
            if (countChecked == 0)
            {
                MessageBox.Show("Vui lòng chọn để xóa! ");
                return;
            }
            DialogResult result = MessageBox.Show(
                 $"Bạn có chắc chắn muốn xóa {countChecked} sản phẩm đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (result != DialogResult.Yes) return;
            SQLiteUtils sQL = new SQLiteUtils();

            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                bool isChecked = row.Cells[0].Value != null &&
                                Convert.ToBoolean(row.Cells[0].Value);
                if (isChecked)
                {
                    int idProduct = Convert.ToInt32(row.Cells["cIDProduct"].Value);
                    string query = $"DELETE FROM Products WHERE ProductID = {idProduct}";
                    sQL.ExecuteQuery(query);
                }
            }
            LoadProduct();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Enabled)
            {
                int idProduct = int.Parse(txtIDProduct.Text);

                DialogResult result = MessageBox.Show(
                 $"Bạn có chắc chắn muốn xóa sản phẩm số {idProduct} không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
                if (result != DialogResult.Yes) return;

                SQLiteUtils sQL = new SQLiteUtils();
                string query = $"DELETE FROM Products WHERE ProductID = {idProduct}";
                sQL.ExecuteQuery(query);

                LoadProduct();
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

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text)) return;

            if (decimal.TryParse(txtPrice.Text.Replace(",", ""), out decimal price))
            {
                txtPrice.Text = price.ToString("#,##0"); // 12000 -> 12,000
            }
            else
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                txtPrice.Focus();
            }
        }
        //--------------------





    }
}
