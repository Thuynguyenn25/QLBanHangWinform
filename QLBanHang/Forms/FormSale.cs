using QLBanHang.Data;
using QLBanHang.Helpers;
using QLBanHang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class FormSale : Form
    {
        public FormSale()
        {
            InitializeComponent();
        }
        private bool _loaded = false;

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
                query = @" SELECT ProductId, Name FROM Products WHERE IsActive = 1";
                dt = sql.ExecuteQuery(query);
            }
            else
            {
                query = $" SELECT ProductId, Name FROM Products WHERE IsActive = 1 AND CategoryId = '{categoryId}'";
                dt = sql.ExecuteQuery(query);
            }

            cboProduct1.DataSource = dt;
            cboProduct1.DisplayMember = "Name";
            cboProduct1.ValueMember = "ProductId";
            cboProduct1.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;

            if (dt.Rows.Count > 0)
            {
                int firstProductId = Convert.ToInt32(dt.Rows[0]["ProductId"]);
                LoadPrice(firstProductId);
            }
            else
            {
                txtUnitPrice.Text = "";
            }

        }
        private void FormSale_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadProduct(0);

            dgvCart.Columns[3].DefaultCellStyle.Format = "#,##0";
            dgvCart.Columns[5].DefaultCellStyle.Format = "#,##0";

            _loaded = true;
        }
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loaded) return;
            if (cboCategory.SelectedValue == null) return;

            int categoryId = Convert.ToInt32(cboCategory.SelectedValue);
            LoadProduct(categoryId);
        }

        private void LoadPrice(int productID)
        {
            productID = Convert.ToInt32(productID);
            string query = $" SELECT Price, Stock FROM Products WHERE ProductId = '{productID}' AND IsActive = 1 LIMIT 1;";

            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
            {
                txtUnitPrice.Text = "";
                return;
            }

            decimal price = Convert.ToDecimal(dt.Rows[0]["Price"]);
            int stock = Convert.ToInt32(dt.Rows[0]["Stock"]);

            txtUnitPrice.Text = price.ToString("#,##0");

        }

        private void cboProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loaded) return;
            if (cboProduct1.SelectedValue == null) return;

            int productId = Convert.ToInt32(cboProduct1.SelectedValue);
            LoadPrice(productId);
        }

        //-----------------
        private int GetStockFromDb(int productId)
        {
            string query = $"SELECT Stock FROM Products WHERE ProductId = {productId} AND IsActive = 1 LIMIT 1;";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboProduct1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm!");
                    return;
                }
                int productId = Convert.ToInt32(cboProduct1.SelectedValue);
                string productName = cboProduct1.Text;

                if (!CheckInput(out int addQty, out decimal unitPrice))
                    return;

                int stock = GetStockFromDb(productId);

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["cProductID"].Value == null) continue;

                    int rowProductId = Convert.ToInt32(row.Cells["cProductID"].Value);

                    if (rowProductId == productId)
                    {
                        int currentQty = Convert.ToInt32(row.Cells["cCount"].Value);
                        int newQty = currentQty + addQty;

                        if (newQty > stock)
                        {
                            MessageBox.Show($"Không đủ tồn kho! Tồn: {stock}, trong giỏ: {currentQty}");
                            return;
                        }
                        row.Cells["cCount"].Value = newQty;
                        row.Cells["cUnitPrice"].Value = unitPrice;
                        row.Cells["cLineTotal"].Value = newQty * unitPrice;
                        RecalcTotalAmount();
                        return;
                    }
                }

                if (addQty > stock)
                {
                    MessageBox.Show($"Không đủ tồn kho! Tồn hiện tại: {stock}");
                    return;
                }

                decimal lineTotal = unitPrice * addQty;

                dgvCart.Rows.Add(
                    false,                    
                    dgvCart.Rows.Count + 1,   
                    productName,              
                    unitPrice,                 
                    addQty,                  
                    lineTotal,                
                    productId                 
                );
                RecalcTotalAmount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Add Cart: ", ex);
            }
        }



        private void RecalcTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[5].Value == null) continue;

                totalAmount += Convert.ToDecimal(row.Cells[5].Value);
            }

            lblTotalAmount.Text = "Tổng tiền: " + totalAmount.ToString("#,##0");

        }
        //-----------
        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //------
        //cập nhật lại STT
        private void ReindexCartSTT()
        {
            int stt = 1;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells[1].Value = stt++;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool hasChecked = false;
            for (int i = dgvCart.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dgvCart.Rows[i];
                if (row.IsNewRow) continue;
                bool isChecked = row.Cells[0].Value != null &&
                                 Convert.ToBoolean(row.Cells[0].Value);
                if (isChecked)
                {
                    dgvCart.Rows.RemoveAt(i);
                    hasChecked = true;
                }
            }
            if (!hasChecked)
            {
                MessageBox.Show("Vui lòng tick sản phẩm cần xóa!");
                return;
            }
            ReindexCartSTT();
            RecalcTotalAmount();
        }

        //-------------------
        private decimal GetCartTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[6].Value == null) continue;

                total += Convert.ToDecimal(row.Cells[6].Value);
            }
            return total;
        }

        private bool CartHasItems()
        {
            foreach (DataGridViewRow row in dgvCart.Rows)
                if (!row.IsNewRow) return true;
            return false;
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

            decimal totalAmount = GetCartTotalAmount();
            string orderDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            SQLiteUtils sql = new SQLiteUtils();

            try
            {
                string insertOrder =
                    $"INSERT INTO Orders(OrderDate, CustomerName, Phone, TotalAmount) " +
                    $"VALUES('{orderDate}', '{nameCustomer}', '{phone}', {totalAmount});";

                sql.ExecuteQuery(insertOrder);

                DataTable dtOrderId = sql.ExecuteQuery(
                    "SELECT MAX(OrderId) AS OrderId FROM Orders;"
                );

                int orderId = Convert.ToInt32(dtOrderId.Rows[0]["OrderId"]);

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.IsNewRow) continue;

                    int productId = Convert.ToInt32(row.Cells["cProductID"].Value);
                    int count = Convert.ToInt32(row.Cells["cCount"].Value);
                    decimal unitPrice = Convert.ToDecimal(row.Cells["cUnitPrice"].Value);
                    decimal lineTotal = Convert.ToDecimal(row.Cells["cLineTotal"].Value);

                    int stockNow = GetStockFromDb(productId);
                    if (count > stockNow)
                    {
                        MessageBox.Show(
                            $"Không đủ tồn kho cho sản phẩm ID={productId}. " +
                            $"Tồn: {stockNow}, cần: {count}"
                        );
                        return;
                    }

                    string insertDetail =
                        $"INSERT INTO OrderDetails(OrderId, ProductId, Quantity, UnitPrice, LineTotal) " +
                        $"VALUES({orderId}, {productId}, {count}, {unitPrice}, {lineTotal});";

                    sql.ExecuteQuery(insertDetail);

                    string updateStock =
                        $"UPDATE Products SET Stock = Stock - {count} " +
                        $"WHERE ProductId = {productId};";

                    sql.ExecuteQuery(updateStock);
                }

                MessageBox.Show($"Đặt hàng thành công! Mã hóa đơn: {orderId}");

                dgvCart.Rows.Clear();
                lblTotalAmount.Text = "Tổng tiền: 0";
                txtCount.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt hàng thất bại: " + ex.Message);
            }
        }




    }
}
