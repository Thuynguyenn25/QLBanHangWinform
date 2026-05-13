using QLBanHang.BLL;
using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Forms;

namespace QLBanHang.Forms
{
    public partial class FormHoaDon : Form
    {
        private int _orderId;
        private readonly OrderBLL _orderBLL = new OrderBLL();

        public FormHoaDon(int orderId)
        {
            InitializeComponent();
            this._orderId = orderId;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            uiDataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0";
            uiDataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0";

            LoadOrderHeader(_orderId);
            LoadOrderDetails(_orderId);
        }

        private void LoadOrderHeader(int orderId)
        {
            var order = _orderBLL.GetOrderById(orderId);

            if (order == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
                return;
            }

            lblName.Text = "Khách hàng: " + order.CustomerName;
            lblPhone.Text = "Số điện thoại: " + order.Phone;
            // Use uiLabel18 for date
            uiLabel18.Text = "Ngày đặt: " + order.OrderDate;

            // Use lblBill for the title but include total
            lblBill.Text = "HÓA ĐƠN #" + orderId + " - Tổng: " + order.TotalAmount.ToString("N0") + " VNĐ";
        }


        private void LoadOrderDetails(int orderId)
        {
            uiDataGridView1.Rows.Clear();

            var details = _orderBLL.GetOrderDetails(orderId);

            foreach (var d in details)
            {
                uiDataGridView1.Rows.Add(
                    false,
                    uiDataGridView1.Rows.Count + 1,
                    d.ProductId,
                    d.ProductName,
                    d.Quantity,
                    d.UnitPrice,
                    d.LineTotal
                );
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            // The designer has btnImport instead of btnExport
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Text file (*.txt)|*.txt";
                    sfd.FileName = $"HoaDon_{_orderId}.txt";

                    if (sfd.ShowDialog() != DialogResult.OK) return;

                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("CÔNG TY CỔ PHẦN .....");
                        sw.WriteLine("Địa chỉ: ....................");
                        sw.WriteLine();
                        sw.WriteLine("========== HÓA ĐƠN BÁN HÀNG ==========");
                        sw.WriteLine($"Mã hóa đơn   : {_orderId}");
                        sw.WriteLine($"Thông tin    : {lblBill.Text}");
                        sw.WriteLine($"Khách hàng   : {lblName.Text}");
                        sw.WriteLine($"Liên hệ      : {lblPhone.Text}");
                        sw.WriteLine("--------------------------------------");

                        sw.WriteLine("STT | Tên hàng | SL | Đơn giá | Thành tiền");
                        sw.WriteLine("--------------------------------------");

                        foreach (DataGridViewRow row in uiDataGridView1.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string stt = row.Cells[1].Value?.ToString() ?? "";
                            string name = row.Cells[3].Value?.ToString() ?? "";
                            string qty = row.Cells[4].Value?.ToString() ?? "";

                            decimal price = row.Cells[5].Value == null ? 0 : Convert.ToDecimal(row.Cells[5].Value);
                            decimal line = row.Cells[6].Value == null ? 0 : Convert.ToDecimal(row.Cells[6].Value);

                            sw.WriteLine($"{stt} | {name} | {qty} | {price:#,##0} | {line:#,##0}");
                        }

                        sw.WriteLine("--------------------------------------");
                        sw.WriteLine("======================================");
                    }
                }

                MessageBox.Show("Xuất hóa đơn TXT thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Export txt Hoa Don: ", ex);
            }
        }
    }
}
