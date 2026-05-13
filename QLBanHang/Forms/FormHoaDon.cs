<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using QLBanHang.BLL;
using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.IO;
using System.Text;
>>>>>>> Stashed changes
using System.Windows.Forms;
using QLBanHang.Forms;

namespace QLBanHang.Forms
{
    public partial class FormHoaDon : Form
    {
<<<<<<< Updated upstream
        public FormHoaDon()
=======
        private int _orderId;
        private readonly OrderBLL _orderBLL = new OrderBLL();

        public FormHoaDon(int orderId)
>>>>>>> Stashed changes
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {

<<<<<<< Updated upstream
=======
            dgvBill.Columns[5].DefaultCellStyle.Format = "#,##0";
            dgvBill.Columns[6].DefaultCellStyle.Format = "#,##0";
        }

        private void LoadOrderHeader(int orderId)
        {
            var order = _orderBLL.GetOrderById(orderId);

            if (order == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn!");
                return;
            }

            txtNameCustomer.Text = order.CustomerName;
            txtPhone.Text = order.Phone;
            lblOrderDate.Text = "Ngày: " + order.OrderDate;
            lblTotalAmount.Text = "Tổng tiền: " + order.TotalAmount.ToString("#,##0");
        }

        private void LoadOrderDetails(int orderId)
        {
            dgvBill.Rows.Clear();

            var details = _orderBLL.GetOrderDetails(orderId);

            foreach (var d in details)
            {
                dgvBill.Rows.Add(
                    false,
                    dgvBill.Rows.Count + 1,
                    d.ProductId,
                    d.ProductName,
                    d.Quantity,
                    d.UnitPrice,
                    d.LineTotal
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
>>>>>>> Stashed changes
        }
    }
}
