using QLBanHang.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLBanHang.Forms
{
    public partial class FormReport : Sunny.UI.UIForm
    {
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

            string fromStr = from.ToString("yyyy-MM-dd HH:mm:ss");
            string toStr = to.ToString("yyyy-MM-dd HH:mm:ss");

            string qTable = $@"
                SELECT 
                    date(OrderDate) AS Ngay,
                    COUNT(*) AS SoDon,
                    COALESCE(SUM(TotalAmount),0) AS DoanhThu
                FROM Orders
                WHERE OrderDate >= '{fromStr}' AND OrderDate <= '{toStr}'
                GROUP BY date(OrderDate)
                ORDER BY date(OrderDate) DESC;";

            string qKpi = $@"
                SELECT 
                    COUNT(*) AS SoDon,
                    COALESCE(SUM(TotalAmount), 0) AS TongDoanhThu,
                    CASE WHEN COUNT(*) = 0 THEN 0
                         ELSE (COALESCE(SUM(TotalAmount), 0) * 1.0 / COUNT(*))
                    END AS GiaTriTB
                FROM Orders
                WHERE OrderDate >= '{fromStr}' AND OrderDate <= '{toStr}';";

            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(qTable);
            DataTable kpi = sql.ExecuteQuery(qKpi);

            dgvRevenue.DataSource = null;
            dgvRevenue.Rows.Clear();

            int stt = 1;
            foreach (DataRow r in dt.Rows)
            {
                dgvRevenue.Rows.Add(
                    stt++,
                    r["Ngay"],
                    r["SoDon"],
                    r["DoanhThu"]
                );
            }

            if (kpi.Rows.Count > 0)
            {
                int soDon = Convert.ToInt32(kpi.Rows[0]["SoDon"]);
                decimal tong = Convert.ToDecimal(kpi.Rows[0]["TongDoanhThu"]);
                decimal tb = Convert.ToDecimal(kpi.Rows[0]["GiaTriTB"]);

                lblOrderCount.Text = $"Số đơn: {soDon}";
                lblTotalRevenue.Text = $"Tổng doanh thu: {tong:#,##0} đ";
                lblAvgOrder.Text = $"Giá trị đơn TB: {tb:#,##0} đ";
            }
            else
            {
                lblOrderCount.Text = "Số đơn: 0";
                lblTotalRevenue.Text = "Tổng doanh thu: 0 đ";
                lblAvgOrder.Text = "Giá trị đơn TB: 0 đ";
            }
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
