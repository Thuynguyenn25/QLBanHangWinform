using QLBanHang.BLL;
using QLBanHang.DTO;
using QLBanHang.Forms;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class FormSale : Form
    {
        private bool _loaded = false;
        private readonly List<CartItemDTO> _cart = new List<CartItemDTO>();

        private readonly ProductBLL _productBLL = new ProductBLL();
        private readonly CategoryBLL _categoryBLL = new CategoryBLL();
        private readonly OrderBLL _orderBLL = new OrderBLL();

        public FormSale()
        {
            InitializeComponent();
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadProduct(0);
            LoadCustomerAutoComplete();

            uiDataGridView2.Columns[3].DefaultCellStyle.Format = "#,##0";
            uiDataGridView2.Columns[5].DefaultCellStyle.Format = "#,##0";

            _loaded = true;
        }

        private void LoadCategory()
        {
            DataTable dt = _categoryBLL.GetAllForSaleComboBox();
            cmbCategory.DataSource = dt;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadProduct(int categoryId = 0)
        {
            DataTable dt = _productBLL.GetActiveProducts(categoryId);

            cmbProduct1.DataSource = dt;
            cmbProduct1.DisplayMember = "Name";
            cmbProduct1.ValueMember = "ProductId";
            cmbProduct1.SelectedIndex = dt.Rows.Count > 0 ? 0 : -1;

            if (dt.Rows.Count > 0)
            {
                string firstProductId = dt.Rows[0]["ProductId"].ToString();
                LoadPrice(firstProductId);
            }
            else
            {
                txtPrice.Text = "";
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loaded) return;
            if (cmbCategory.SelectedValue == null) return;
            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            LoadProduct(categoryId);
        }

        private void cmbProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_loaded) return;
            if (cmbProduct1.SelectedValue == null) return;
            string productId = cmbProduct1.SelectedValue.ToString();
            LoadPrice(productId);
        }

        private void LoadPrice(string productId)
        {
            var info = _productBLL.GetActiveProductInfo(productId);
            if (info == null)
            {
                txtPrice.Text = "";
                return;
            }
            txtPrice.Text = info.Price.ToString("#,##0");
        }

        private bool CheckInput(out int count, out decimal unitPrice)
        {
            count = 0;
            unitPrice = 0;

            if (!int.TryParse(txtInventory.Text, out count) || count <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!");
                txtInventory.Focus();
                return false;
            }

            string priceText = txtPrice.Text.Replace(",", "").Trim();
            if (!decimal.TryParse(priceText, out unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá không hợp lệ!");
                txtPrice.Focus();
                return false;
            }

            return true;
        }

        private void ReloadCartGrid()
        {
            uiDataGridView2.Rows.Clear();
            int stt = 1;

            foreach (var item in _cart)
            {
                uiDataGridView2.Rows.Add(
                    false, stt++, item.ProductName, item.UnitPrice,
                    item.Quantity, item.LineTotal, item.ProductId);
            }

            lblTotal.Text = "Tổng tiền: " + _cart.Sum(x => x.LineTotal).ToString("#,##0");
        }

        private bool CartHasItems() => _cart.Count > 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm!");
                    return;
                }

                string productId = cmbProduct1.SelectedValue.ToString();
                string productName = cmbProduct1.Text;

                if (!CheckInput(out int addQty, out decimal unitPrice))
                    return;

                int stock = _productBLL.GetStock(productId);

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
                    _cart.Add(new CartItemDTO
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
            if (uiDataGridView2.Rows.Count == 0) return;

            bool hasChecked = false;

            for (int i = uiDataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                var row = uiDataGridView2.Rows[i];
                if (row.IsNewRow) continue;

                bool isChecked = row.Cells[0].Value != null && Convert.ToBoolean(row.Cells[0].Value);
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
            string phone = uiTextBox5.Text.Trim(); // Phone is uiTextBox5 in designer

            if (string.IsNullOrWhiteSpace(nameCustomer))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
                txtNameCustomer.Focus();
                return;
            }

            try
            {
                var (success, message, orderId) = _orderBLL.PlaceOrder(nameCustomer, phone, _cart);

                if (!success)
                {
                    MessageBox.Show(message);
                    return;
                }

                MessageBox.Show(message);

                var f = new FormHoaDon(orderId);
                f.ShowDialog();

                _cart.Clear();
                ReloadCartGrid();
                txtInventory.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt hàng thất bại: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomerAutoComplete()
        {
            var names = _orderBLL.GetDistinctCustomerNames();
            var srcName = new AutoCompleteStringCollection();
            foreach (var n in names) srcName.Add(n);
            txtNameCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNameCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNameCustomer.AutoCompleteCustomSource = srcName;

            var phones = _orderBLL.GetDistinctPhones();
            var srcPhone = new AutoCompleteStringCollection();
            foreach (var p in phones) srcPhone.Add(p);
            uiTextBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            uiTextBox5.AutoCompleteSource = AutoCompleteSource.CustomSource;
            uiTextBox5.AutoCompleteCustomSource = srcPhone;
        }
    }
}
