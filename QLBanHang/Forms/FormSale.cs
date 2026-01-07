using QLBanHang.Data;
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

            txtUnitPrice.Text = price.ToString("0.##");

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
            if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                txtUnitPrice.Focus();
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboProduct1.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }
            int productId = Convert.ToInt32(cboProduct1.SelectedValue);
            string productName = cboProduct1.Text;

            if (!CheckInput(out int count, out decimal unitPrice))
                return;
            int stock = GetStockFromDb(productId);
            decimal lineTotal = unitPrice * count;
            if (count > stock)
            {
                MessageBox.Show($"Không đủ tồn kho! Tồn hiện tại: {stock}");
                return;
            }
            
            dgvCart.Rows.Add(false,dgvCart.Rows.Count+1,productName, count, unitPrice, lineTotal);

            RecalcTotalAmount();
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

            lblTotalAmount.Text = "Tổng tiền: " + totalAmount.ToString("0,0"); 
        }


    }
}
