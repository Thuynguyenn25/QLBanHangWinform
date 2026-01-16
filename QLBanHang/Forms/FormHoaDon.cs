using QLBanHang.Data;
using QLBanHang.Helpers;
using System;
using System.Data;
using System.IO;              // ✅ cần cho StreamWriter
using System.Text;            // ✅ cần cho Encoding
using System.Windows.Forms;

namespace QLBanHang.Forms
{
    public partial class FormHoaDon : Form
    {
        private int _orderId;

        public FormHoaDon(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadOrderHeader(_orderId);
            LoadOrderDetails(_orderId);

            dgvBill.Columns[5].DefaultCellStyle.Format = "#,##0";
            dgvBill.Columns[6].DefaultCellStyle.Format = "#,##0";
        }

        private void LoadOrderHeader(int orderId)
        {
            string q = $"SELECT OrderDate, CustomerName, Phone, TotalAmount FROM Orders WHERE OrderId = {orderId} LIMIT 1;";
            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(q);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
                return;
            }

            DataRow row = dt.Rows[0];

            txtNameCustomer.Text = row["CustomerName"]?.ToString() ?? "";
            txtPhone.Text = row["Phone"]?.ToString() ?? "";
            lblOrderDate.Text = "Ngày: " + row["OrderDate"]?.ToString() ?? "";

            decimal total = Convert.ToDecimal(row["TotalAmount"]);
            lblTotalAmount.Text = "Tổng tiền: " + total.ToString("#,##0");
        }

        private void LoadOrderDetails(int orderId)
        {
            dgvBill.Rows.Clear();

            string query = $@"
                SELECT od.ProductId,
                       p.Name AS ProductName,
                       od.Quantity,
                       od.UnitPrice,
                       od.LineTotal
                FROM OrderDetails od
                JOIN Products p ON p.ProductId = od.ProductId
                WHERE od.OrderId = {orderId};";

            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(query);


            foreach (DataRow r in dt.Rows)
            {
                dgvBill.Rows.Add(
                    false,
                    dgvBill.Rows.Count + 1,
                    r["ProductId"],
                    r["ProductName"],
                    r["Quantity"],
                    r["UnitPrice"],
                    r["LineTotal"]
                );
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
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
                        sw.WriteLine($"Ngày         : {lblOrderDate.Text}");
                        sw.WriteLine($"Khách hàng   : {txtNameCustomer.Text}");
                        sw.WriteLine($"Số điện thoại: {txtPhone.Text}");
                        sw.WriteLine("--------------------------------------");

                        sw.WriteLine("STT | Tên hàng | SL | Đơn giá | Thành tiền");
                        sw.WriteLine("--------------------------------------");

                        foreach (DataGridViewRow row in dgvBill.Rows)
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
                        sw.WriteLine($"TỔNG TIỀN: {lblTotalAmount.Text} VNĐ");
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
