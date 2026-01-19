using QLBanHang.Data;
using QLBanHang.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QLBanHang
{
    public partial class FormProduct : Sunny.UI.UIForm
    {
        private bool _isAddMode = true;

        private bool _suppressCategoryChanged = false;

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
            ActiveProductCount();
            lblTotalActive.Text = $"Đang bán: {GetActiveProductCount()}";
        }

        public void LoadCategories()
        {
            string queryCate = "SELECT CategoryID, Name FROM Categories ORDER BY Name";
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(queryCate);

            _suppressCategoryChanged = true; // ✅ FIX
            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedIndex = 0;
            _suppressCategoryChanged = false; // ✅ FIX
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProduct();

            EnterAddMode();
        }
        //-------------------

        public bool ValidateInput()
        {
            if (cboCategory.SelectedIndex == -1 || cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục");
                return false;
            }

            if (_isAddMode && string.IsNullOrWhiteSpace(txtIDProduct.Text))
            {
                int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
                txtIDProduct.Text = GenerateProductID(categoryId);
            }

            string productId = txtIDProduct.Text.Trim();
            if (productId.Contains(",")) { MessageBox.Show("Mã hàng không được chứa dấu phẩy"); return false; }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên hàng");
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
        //-------------------------------------------
        private void SetButtonState(bool isEditing)
        {
            btnAdd.Enabled = !isEditing;
            btnEdit.Enabled = isEditing;
            btnDelete.Enabled = isEditing;
            txtIDProduct.Enabled = !isEditing;

           // txtIDProduct.Enabled = true; 
        }


        private void EnterAddMode()
        {
            _isAddMode = true;
            SetButtonState(false);
            if (cboCategory.SelectedValue != null)
            {
                int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
                txtIDProduct.Text = GenerateProductID(categoryId);
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
            chkIsActive.Checked = !chkIsActive.Checked;

            dgvProduct.ClearSelection();
            dgvProduct.CurrentCell = null;

            EnterAddMode();
        }

        //------------------------------
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                _isAddMode = true;

                if (!ValidateInput()) return;

                int categoryID = Convert.ToInt32(cboCategory.SelectedValue);

                string productID = GenerateProductID(categoryID);
                txtIDProduct.Text = productID;

                string name = txtName.Text.Trim().Replace("'", "''");
                decimal price = decimal.Parse(txtPrice.Text.Replace(",", ""));
                int stock = int.Parse(txtStock.Text.Trim());
                int isActive = chkIsActive.Checked ? 1 : 0;

                SQLiteUtils sQL = new SQLiteUtils();

                DataTable dtCheck = sQL.ExecuteQuery(
                    $"SELECT 1 FROM Products WHERE ProductID = '{productID}' LIMIT 1;"
                );
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Mã sản phẩm vừa sinh đã tồn tại. Thử lại!");
                    txtIDProduct.Text = GenerateProductID(categoryID);
                    return;
                }

                string query =
                    $"INSERT INTO Products(ProductID, Name, CategoryID, Price, Stock, IsActive) " +
                    $"VALUES('{productID}', '{name}', {categoryID}, {price}, {stock}, {isActive});";

                sQL.ExecuteQuery(query);

                MessageBox.Show($"Đã thêm sản phẩm thành công: {productID}");
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
            if (e.RowIndex < 0) return;

            EnterEditMode(); 

            DataGridViewRow row = dgvProduct.Rows[e.RowIndex];

            txtIDProduct.Text = row.Cells["cIDProduct"].Value?.ToString() ?? "";
            txtName.Text = row.Cells["cName"].Value?.ToString() ?? "";

            string p = row.Cells["cPrice"].Value?.ToString() ?? "0";
            if (decimal.TryParse(p.Replace(",", ""), out decimal pr))
                txtPrice.Text = pr.ToString("#,##0");
            else
                txtPrice.Text = p;

            txtStock.Text = row.Cells["cStock"].Value?.ToString() ?? "";

            _suppressCategoryChanged = true;
            if (row.Cells["cCategoryID"].Value != null)
                cboCategory.SelectedValue = Convert.ToInt32(row.Cells["cCategoryID"].Value);
            else
                cboCategory.SelectedIndex = -1;
            _suppressCategoryChanged = false;

            int isActive = (row.Cells["cIsActive"].Value?.ToString() == "Đang bán") ? 1 : 0;
            chkIsActive.Checked = (isActive == 1);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
        
                _isAddMode = false;

                if (!ValidateInput()) return;

                string productID = txtIDProduct.Text.Trim().Replace("'", "''");
                string name = txtName.Text.Trim().Replace("'", "''");
                decimal price = decimal.Parse(txtPrice.Text.Replace(",", ""));
                int stock = int.Parse(txtStock.Text.Trim());
                int categoryID = Convert.ToInt32(cboCategory.SelectedValue);
                int isActive = chkIsActive.Checked ? 1 : 0;

                string query =
                    $"UPDATE Products SET " +
                    $"Name='{name}', CategoryID={categoryID}, Price={price}, Stock={stock}, IsActive={isActive} " +
                    $"WHERE ProductID='{productID}';";

                SQLiteUtils sQL = new SQLiteUtils();
                sQL.ExecuteQuery(query);

                MessageBox.Show("Đã sửa thành công");
                LoadProduct();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Update Product: ", ex);
            }
        }
        //--------------------
    
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
                LoadProduct();
            else
                SearchProduct();
        }

   
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
                row.Cells[0].Value = true;
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
                row.Cells[0].Value = true;
        }

        private void tsmiUnselect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
                row.Cells[0].Value = false;
        }
        //--------------------
        private bool IsProductUsedInOrders(string productId)
        {
            SQLiteUtils sql = new SQLiteUtils();
            string safeId = productId.Replace("'", "''");

            DataTable dt = sql.ExecuteQuery(
                $"SELECT 1 FROM OrderDetails WHERE ProductID = '{safeId}' LIMIT 1;"
            );

            return dt.Rows.Count > 0;
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            int countChecked = 0;
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                bool isCheck = row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value);
                if (isCheck) countChecked++;
            }
            if (countChecked == 0)
            {
                MessageBox.Show("Vui lòng chọn để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa {countChecked} sản phẩm đã chọn không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result != DialogResult.Yes) return;

            SQLiteUtils sql = new SQLiteUtils();

            int deleted = 0, disabled = 0;

            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                bool isChecked = row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value);
                if (!isChecked) continue;

                string idProduct = row.Cells["cIDProduct"].Value?.ToString() ?? "";
                if (string.IsNullOrWhiteSpace(idProduct)) continue;

                string safeId = idProduct.Replace("'", "''");

                if (IsProductUsedInOrders(idProduct))
                {
                    sql.ExecuteQuery($"UPDATE Products SET IsActive = 0 WHERE ProductID = '{safeId}';");
                    disabled++;
                }
                else
                {
                    sql.ExecuteQuery($"DELETE FROM Products WHERE ProductID = '{safeId}';");
                    deleted++;
                }
            }

            MessageBox.Show($"Xong!\nĐã xóa: {deleted}\nĐã chuyển Ngừng bán: {disabled}");
            LoadProduct();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!btnDelete.Enabled) return;

            string idProduct = txtIDProduct.Text.Trim();
            if (string.IsNullOrWhiteSpace(idProduct))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm số {idProduct} không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result != DialogResult.Yes) return;

            SQLiteUtils sql = new SQLiteUtils();
            string safeId = idProduct.Replace("'", "''");

            // ✅ Nếu đã từng bán -> chỉ ngừng bán
            if (IsProductUsedInOrders(idProduct))
            {
                sql.ExecuteQuery($"UPDATE Products SET IsActive = 0 WHERE ProductID = '{safeId}';");
                MessageBox.Show("Sản phẩm đã có trong đơn hàng nên không thể xóa. Đã chuyển sang Ngừng bán.");
            }
            else
            {
                sql.ExecuteQuery($"DELETE FROM Products WHERE ProductID = '{safeId}';");
                MessageBox.Show("Đã xóa sản phẩm.");
            }

            LoadProduct();
            Clear();
        }

        //-------------------------
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
                txtPrice.Text = price.ToString("#,##0");
            else
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                txtPrice.Focus();
            }
        }

        private void ActiveProductCount()
        {
            string query = "SELECT COUNT(*) AS Total FROM Products WHERE IsActive = 1";
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(query);

            int total = 0;
            if (dt.Rows.Count > 0)
                total = Convert.ToInt32(dt.Rows[0]["Total"]);

            lblTotalActive.Text = $"Đang bán: {total}";
        }

        // ---------------
        private void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "CSV file (*.csv)|*.csv";
                if (ofd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    int inserted = 0, updated = 0, skipped = 0;
                    string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);

                    if (lines.Length <= 1)
                    {
                        MessageBox.Show("File CSV trống hoặc không đúng định dạng!");
                        return;
                    }

                    SQLiteUtils sql = new SQLiteUtils();

                    for (int i = 1; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();
                        if (string.IsNullOrWhiteSpace(line)) { skipped++; continue; }

                        string[] parts = line.Split(',');
                        if (parts.Length < 6) { skipped++; continue; }

                        string productId = parts[0].Trim();
                        if (string.IsNullOrWhiteSpace(productId)) { skipped++; continue; }
                        if (productId.Contains(",")) { skipped++; continue; }

                        string name = parts[1].Trim();
                        if (string.IsNullOrWhiteSpace(name)) { skipped++; continue; }

                        if (!int.TryParse(parts[2].Trim(), out int categoryId)) { skipped++; continue; }

                        string priceText = parts[3].Trim().Replace(",", "");
                        if (!decimal.TryParse(priceText, out decimal price) || price < 0) { skipped++; continue; }

                        if (!int.TryParse(parts[4].Trim(), out int stock) || stock < 0) { skipped++; continue; }

                        if (!int.TryParse(parts[5].Trim(), out int isActive)) { skipped++; continue; }
                        isActive = (isActive == 1) ? 1 : 0;

                        string safeId = productId.Replace("'", "''");
                        string safeName = name.Replace("'", "''");

                        DataTable dtCheck = sql.ExecuteQuery(
                            $"SELECT 1 FROM Products WHERE ProductID = '{safeId}' LIMIT 1;"
                        );

                        if (dtCheck.Rows.Count > 0)
                        {
                            string qUpdate =
                                $"UPDATE Products SET " +
                                $"Name='{safeName}', CategoryID={categoryId}, Price={price}, Stock={stock}, IsActive={isActive} " +
                                $"WHERE ProductID='{safeId}';";

                            sql.ExecuteQuery(qUpdate);
                            updated++;
                        }
                        else
                        {
                            string qInsert =
                                $"INSERT INTO Products(ProductID, Name, CategoryID, Price, Stock, IsActive) " +
                                $"VALUES('{safeId}', '{safeName}', {categoryId}, {price}, {stock}, {isActive});";

                            sql.ExecuteQuery(qInsert);
                            inserted++;
                        }
                    }

                    MessageBox.Show($"Import xong!\nThêm mới: {inserted}\nCập nhật: {updated}\nBỏ qua: {skipped}");
                    LoadProduct();
                    Clear(); // ✅ quay về add mode
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Import thất bại: " + ex.Message);
                    Utils.Log("Import CSV: ", ex);
                }
            }
        }

        private int GetActiveProductCount()
        {
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery("SELECT COUNT(*) FROM Products WHERE IsActive = 1");
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        private string GenerateProductID(int categoryId)
        {
            SQLiteUtils sql = new SQLiteUtils();

            DataTable dtCate = sql.ExecuteQuery(
                $"SELECT Name FROM Categories WHERE CategoryID = {categoryId}"
            );
            if (dtCate.Rows.Count == 0) return "";

            string cateName = dtCate.Rows[0]["Name"].ToString().Trim();

            string[] words = cateName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string prefix;
            if (words.Length >= 2)
                prefix = $"{char.ToUpper(words[0][0])}{char.ToUpper(words[1][0])}";
            else
                prefix = $"{char.ToUpper(words[0][0])}X";

            DataTable dtMax = sql.ExecuteQuery(
                $@"SELECT ProductID
                   FROM Products
                   WHERE ProductID LIKE '{prefix}%'
                   ORDER BY ProductID DESC
                   LIMIT 1"
            );

            int nextNumber = 1;
            if (dtMax.Rows.Count > 0)
            {
                string lastId = dtMax.Rows[0]["ProductID"].ToString();
                string numPart = lastId.Substring(2);
                if (int.TryParse(numPart, out int n))
                    nextNumber = n + 1;
            }

            return $"{prefix}{nextNumber:00}";
        }
        //------------------------
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (_suppressCategoryChanged) return;
            if (!_isAddMode) return;

            if (cboCategory.SelectedItem == null) return;

            var drv = cboCategory.SelectedItem as DataRowView;
            if (drv == null) return;

            int categoryId = Convert.ToInt32(drv["CategoryID"]);
            txtIDProduct.Text = GenerateProductID(categoryId);
        }
    }
}
