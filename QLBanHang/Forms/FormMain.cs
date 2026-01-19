using QLBanHang.Data;
using QLBanHang.Forms;
using System;
using System.Data;
using System.Windows.Forms;
using Sunny.UI;


namespace QLBanHang
{
    public partial class FrmMain : Sunny.UI.UIForm
    {
        public FrmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            foreach (ToolStripMenuItem item in msMenu.Items)
                item.MouseEnter += TopMenu_MouseEnter;
        }
        private void FrmMain_Load_1(object sender, EventArgs e)
        {
            LoadDashboardKpi();
            LoadWeeklyRevenueBarChart(4);
        }
        private void LoadDashboardKpi()
        {
            string today = DateTime.Today.ToString("yyyy-MM-dd");
            string yesterday = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");

            string qToday = $@"
                SELECT 
                    COUNT(*) AS SoDon,
                    COALESCE(SUM(TotalAmount), 0) AS DoanhThu
                FROM Orders
                WHERE OrderDate LIKE '{today}%';";

            string qYesterday = $@"
                SELECT 
                    COALESCE(SUM(TotalAmount), 0) AS DoanhThu
                FROM Orders
                WHERE OrderDate LIKE '{yesterday}%';";

            int threshold = 5;
            string qLowStock = $@"
                SELECT COUNT(*) AS SoSP
                FROM Products
                WHERE IsActive = 1 AND Stock <= {threshold};";

            SQLiteUtils sql = new SQLiteUtils();
            DataTable dtToday = sql.ExecuteQuery(qToday);
            DataTable dtY = sql.ExecuteQuery(qYesterday);
            DataTable dtLow = sql.ExecuteQuery(qLowStock);

            int soDonToday = 0;
            decimal doanhThuToday = 0;
            decimal doanhThuYesterday = 0;
            int lowStockCount = 0;

            if (dtToday.Rows.Count > 0)
            {
                soDonToday = Convert.ToInt32(dtToday.Rows[0]["SoDon"]);
                doanhThuToday = Convert.ToDecimal(dtToday.Rows[0]["DoanhThu"]);
            }

            if (dtY.Rows.Count > 0)
            {
                doanhThuYesterday = Convert.ToDecimal(dtY.Rows[0]["DoanhThu"]);
            }

            if (dtLow.Rows.Count > 0)
            {
                lowStockCount = Convert.ToInt32(dtLow.Rows[0]["SoSP"]);
            }

            lblRevenueToday.Text = $"{doanhThuToday:#,##0} đ";

            lblOrderCount.Text = $"{soDonToday}";

            lblProductEx.Text = $"{lowStockCount} SP (<= {threshold})";

            if (doanhThuYesterday <= 0)
            {
                lblSub.Text = (doanhThuToday > 0)
                    ? "So với hôm qua: ↑ mới phát sinh"
                    : "So với hôm qua: —";
            }
            else
            {
                decimal pct = (doanhThuToday - doanhThuYesterday) / doanhThuYesterday * 100m;
                string arrow = pct >= 0 ? "↑" : "↓";
                lblSub.Text = $"So với hôm qua: {arrow} {pct:0.##}%";
            }
        }


        private void TopMenu_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem menuItem && menuItem.HasDropDownItems)
                menuItem.ShowDropDown();
        }

        private void tmrTimeFt_Tick(object sender, EventArgs e)
        {
            statusTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void tsmiCategory_Click(object sender, EventArgs e)
        {
            var f = new FormCategory();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void tsmiProduct_Click(object sender, EventArgs e)
        {
            var f = new FormProduct();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void tsmiSale_Click(object sender, EventArgs e)
        {
            var f = new FormSale();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.FormClosed += (s, args) =>
            {
                LoadDashboardKpi();
                LoadWeeklyRevenueBarChart(4);
            };

            f.Show();
        }

        private void tsmiReport_Click(object sender, EventArgs e)
        {
            var f = new FormReport();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void LoadWeeklyRevenueBarChart(int weeks = 4)
        {
            int days = weeks * 7 - 1;

            string q = $@"
        SELECT 
            strftime('%Y', OrderDate) || '-W' || strftime('%W', OrderDate) AS Tuan,
            COALESCE(SUM(TotalAmount), 0) AS DoanhThu
        FROM Orders
        WHERE date(OrderDate) >= date('now', '-{days} day')
        GROUP BY strftime('%Y', OrderDate), strftime('%W', OrderDate)
        ORDER BY strftime('%Y', OrderDate), strftime('%W', OrderDate);";

            SQLiteUtils sql = new SQLiteUtils();
            DataTable dt = sql.ExecuteQuery(q);

            var option = new UIBarOption();

            option.Title = new UITitle();
            option.Title.Text = "Doanh thu theo tuần";

            option.ToolTip.Visible = true;

            var s1 = new UIBarSeries();
            s1.Name = "Doanh thu";

            foreach (DataRow r in dt.Rows)
            {
                string week = r["Tuan"].ToString();
                double revenue = Convert.ToDouble(r["DoanhThu"]);

                option.XAxis.Data.Add(week);
                s1.AddData(revenue);
            }

            option.Series.Add(s1);
            uiBarChartWeek.SetOption(option);
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
