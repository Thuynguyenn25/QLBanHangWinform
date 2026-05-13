using QLBanHang.BLL;
using QLBanHang.DTO;
using System;
using System.Windows.Forms;

namespace QLBanHang.Forms
{
    public partial class FormReport : Sunny.UI.UIForm
    {
        private readonly OrderBLL _orderBLL = new OrderBLL();

        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today.AddDays(1).AddSeconds(-1);

            dtpFromDate.Text = dtpFromDate.Value.ToString("yyyy-MM-dd HH:mm:ss");
            dtpToDate.Text = dtpToDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            dtpFromDate.ValueChanged += (s, ev) =>
                dtpFromDate.Text = dtpFromDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            dtpToDate.ValueChanged += (s, ev) =>
                dtpToDate.Text = dtpToDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            dgvRevenue.AutoGenerateColumns = false;
            dgvRevenue.AllowUserToAddRows = false;
            dgvRevenue.ReadOnly = true;
            dgvRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvRevenue.Columns["colDoanhThu"] != null)
                dgvRevenue.Columns["colDoanhThu"].DefaultCellStyle.Format = "#,##0";

            dgvRevenue.RowPostPaint += dgvRevenue_RowPostPaint;

            LoadRevenueReport();
        }

        private void LoadRevenueReport()
        {
            DateTime from = dtpFromDate.Value;
            DateTime to = dtpToDate.Value;

            if (from > to)
            {
                MessageBox.Show("Từ ngày phải <= Tới ngày", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dailyData = _orderBLL.GetDailyRevenue(from, to);
            var kpi = _orderBLL.GetReportKpi(from, to);

            dgvRevenue.DataSource = null;
            dgvRevenue.Rows.Clear();

            int stt = 1;
            foreach (var d in dailyData)
            {
                dgvRevenue.Rows.Add(stt++, d.Ngay, d.SoDon, d.DoanhThu);
            }

            lblOrderCount.Text = $"Số đơn: {kpi.SoDon}";
            lblTotalRevenue.Text = $"Tổng doanh thu: {kpi.TongDoanhThu:#,##0} đ";
            lblAvgOrder.Text = $"Giá trị đơn TB: {kpi.GiaTriTB:#,##0} đ";
        }

        private void dgvRevenue_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dgvRevenue.Columns["colSTT"] == null) return;
            dgvRevenue.Rows[e.RowIndex].Cells["colSTT"].Value = (e.RowIndex + 1).ToString();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            LoadRevenueReport();
        }
    }
}
