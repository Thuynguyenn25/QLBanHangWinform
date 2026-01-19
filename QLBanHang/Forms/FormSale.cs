using QLBanHang.Data;
using QLBanHang.Forms;
using QLBanHang.Helpers;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class FormSale : Sunny.UI.UIForm
    {
        public FormSale()
        {
            InitializeComponent();
        }

        private bool _loaded = false;

        private readonly List<CartItem> _cart = new List<CartItem>();

        private void FormSale_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadProduct(0);

            LoadCustomerAutoComplete();

            dgvCart.Columns[3].DefaultCellStyle.Format = "#,##0";
            dgvCart.Columns[5].DefaultCellStyle.Format = "#,##0";

            _loaded = true;
        }

        private void LoadCategory()
        {
            string query = "SELECT CategoryID, Name FROM Categories";
            SQLiteUtils sQL = new SQLiteUtils();
            DataTable dt = sQL.ExecuteQuery(query);

            DataRow allRow = dt.NewRow();
            allRow["CategoryID"] = 0;
            allRow["Name"] = "Tất cả";
            dt.Rows.InsertAt(allRow, 0);

            cboCategory.DataSource = dt;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "CategoryID";
            cboCategory.SelectedIndex = 0;
        }

        private void LoadProduct(int categoryId = 0)
        {
            string query;
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt;

            if (categoryId == 0)
            {
                query = @"SELECT ProductId, Name FROM Products WHERE IsActive = 1";
                dt = sql.ExecuteQuery(query);
            }
            else
            {
                query = $"SELECT ProductId, Name FROM Products WHERE IsActive = 1 AND CategoryId = '{categoryId}'";
                dt = sql.ExecuteQuery(query);
            }

            cboProduct1.DataSource = dt;
            cboProduct1.DisplayMember = "Name";
            cboProduct1.ValueMember = "ProductId";
            cboProduct1.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;

            if (dt.Rows.Count > 0)
            {
                string firstProductId = dt.Rows[0]["ProductId"].ToString();
                LoadPrice(firstProductId);
            }
            else
            {
                txtUnitPrice.Text = "";
            }
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loaded) return;
            if (cboCategory.SelectedValue == null) return;

            int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
            LoadProduct(categoryId);
        }

        private void cboProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loaded) return;
            if (cboProduct1.SelectedValue == null) return;

            string productId = cboProduct1.SelectedValue.ToString();
            LoadPrice(productId);

        }

        private void LoadPrice(string productId)
        {
            string safeId = productId.Replace("'", "''");
            string query = $"SELECT Price, Stock FROM Products WHERE ProductId = '{safeId}' AND IsActive = 1 LIMIT 1;";
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                txtUnitPrice.Text = "";
                return;
            }
            decimal price = Convert.ToDecimal(dt.Rows[0]["Price"]);
            txtUnitPrice.Text = price.ToString("#,##0");
        }


        private int GetStockFromDb(string productId)
        {
            string safeId = productId.Replace("'", "''");

            string query = $"SELECT Stock FROM Products WHERE ProductId = '{safeId}' AND IsActive = 1 LIMIT 1;";
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(query);

            if (dt.Rows.Count == 0) return 0;
            return Convert.ToInt32(dt.Rows[0]["Stock"]);
        }


        private bool CheckInput(out int count, out decimal unitPrice)
        {
            count = 0;
            unitPrice = 0;

            if (!int.TryParse(txtCount.Text, out count) || count <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                txtCount.Focus();
                return false;
            }

            string priceText = txtUnitPrice.Text.Replace(",", "").Trim();
            if (!decimal.TryParse(priceText, out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                txtUnitPrice.Focus();
                return false;
            }

            return true;
        }

        private void ReloadCartGrid()
        {
            dgvCart.Rows.Clear();
            int stt = 1;

            foreach (var item in _cart)
            {
                dgvCart.Rows.Add(
                    false,
                    stt++,
                    item.ProductName,
                    item.UnitPrice,
                    item.Quantity,
                    item.LineTotal,
                    item.ProductId
                );
            }

            lblTotalAmount.Text = "Tổng tiền: " + _cart.Sum(x => x.LineTotal).ToString("#,##0");
        }

        private bool CartHasItems() => _cart.Count > 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProduct1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm!");
                    return;
                }

                string productId = cboProduct1.SelectedValue.ToString();
                string productName = cboProduct1.Text;

                if (!CheckInput(out int addQty, out decimal unitPrice))
                    return;

                int stock = GetStockFromDb(productId);

                var item = _cart.FirstOrDefault(x => x.ProductId == productId);

                if (item != null)
                {
                    int newQty = item.Quantity + addQty;

                    if (newQty > stock)
                    {
                        MessageBox.Show($"Không đủ tồn kho! Tồn: {stock}, trong giỏ: {item.Quantity}");
                        return;
                    }

                    item.Quantity = newQty;
                    item.UnitPrice = unitPrice;
                }
                else
                {
                    if (addQty > stock)
                    {
                        MessageBox.Show($"Không đủ tồn kho! Tồn hiện tại: {stock}");
                        return;
                    }

                    _cart.Add(new CartItem
                    {
                        ProductId = productId,
                        ProductName = productName,
                        Quantity = addQty,
                        UnitPrice = unitPrice
                    });
                }

                ReloadCartGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Add Cart: ", ex);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0) return;

            bool hasChecked = false;

            for (int i = dgvCart.Rows.Count - 1; i >= 0; i--)
            {
                var row = dgvCart.Rows[i];
                if (row.IsNewRow) continue;

                bool isChecked = row.Cells[0].Value != null &&
                                 Convert.ToBoolean(row.Cells[0].Value);

                if (!isChecked) continue;

                string productId = row.Cells["cProductID"].Value?.ToString() ?? "";
                _cart.RemoveAll(x => x.ProductId == productId);

                hasChecked = true;
            }

            if (!hasChecked)
            {
                MessageBox.Show("Vui lòng tick sản phẩm cần xóa!");
                return;
            }

            ReloadCartGrid();
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!CartHasItems())
            {
                MessageBox.Show("Giỏ hàng đang trống!");
                return;
            }

            string nameCustomer = txtNameCustomer.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(nameCustomer))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txtNameCustomer.Focus();
                return;
            }


            nameCustomer = nameCustomer.Replace("'", "''");
            phone = phone.Replace("'", "''");

            decimal totalAmount = _cart.Sum(x => x.LineTotal);
            string orderDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            SQLiteUtils sql = new SQLiteUtils();

            try
            {
                string insertOrder =
                    $"INSERT INTO Orders(OrderDate, CustomerName, Phone, TotalAmount) " +
                    $"VALUES('{orderDate}', '{nameCustomer}', '{phone}', {totalAmount});";

                sql.ExecuteQuery(insertOrder);

                DataTable dtOrderId = sql.ExecuteQuery("SELECT MAX(OrderId) AS OrderId FROM Orders;");
                int orderId = Convert.ToInt32(dtOrderId.Rows[0]["OrderId"]);

                foreach (var item in _cart)
                {
                    int stockNow = GetStockFromDb(item.ProductId);
                    if (item.Quantity > stockNow)
                    {
                        MessageBox.Show(
                            $"Không đủ tồn kho cho sản phẩm {item.ProductName}. " +
                            $"Tồn: {stockNow}, cần: {item.Quantity}"
                        );
                        return;
                    }

                    string insertDetail =
                        $"INSERT INTO OrderDetails(OrderId, ProductId, Quantity, UnitPrice, LineTotal) " +
                        $"VALUES({orderId}, '{item.ProductId}', {item.Quantity}, {item.UnitPrice}, {item.LineTotal});";

                    sql.ExecuteQuery(insertDetail);

                    string updateStock =
                        $"UPDATE Products SET Stock = Stock - {item.Quantity} WHERE ProductId = '{item.ProductId}';";

                    sql.ExecuteQuery(updateStock);
                }

                MessageBox.Show($"Đặt hàng thành công! Mã hóa đơn: {orderId}");

                var f = new FormHoaDon(orderId);
                f.ShowDialog();

                _cart.Clear();
                ReloadCartGrid();
                txtCount.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt hàng thất bại: " + ex.Message);
            }
        }
        //-------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------------

        private void LoadCustomerAutoComplete()
        {
            SQLiteUtils sql = new SQLiteUtils();

            DataTable dtName = sql.ExecuteQuery(@"
                SELECT DISTINCT CustomerName
                FROM Orders
                WHERE CustomerName IS NOT NULL AND TRIM(CustomerName) <> ''
                ORDER BY CustomerName;
            ");

            var srcName = new AutoCompleteStringCollection();
            foreach (DataRow r in dtName.Rows) srcName.Add(r["CustomerName"].ToString());

            txtNameCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNameCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNameCustomer.AutoCompleteCustomSource = srcName;

            DataTable dtPhone = sql.ExecuteQuery(@"
                SELECT DISTINCT Phone
                FROM Orders
                WHERE Phone IS NOT NULL AND TRIM(Phone) <> ''
                ORDER BY Phone;
            ");

            var srcPhone = new AutoCompleteStringCollection();
            foreach (DataRow r in dtPhone.Rows) srcPhone.Add(r["Phone"].ToString());

            txtPhone.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPhone.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPhone.AutoCompleteCustomSource = srcPhone;
        }


    }
}
