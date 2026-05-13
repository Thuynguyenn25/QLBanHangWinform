namespace QLBanHang.DTO
{
    /// <summary>
    /// DTO chứa thông tin KPI cho Dashboard
    /// </summary>
    public class DashboardKpiDTO
    {
        public int SoDonToday { get; set; }
        public decimal DoanhThuToday { get; set; }
        public decimal DoanhThuYesterday { get; set; }
        public int LowStockCount { get; set; }
        public int LowStockThreshold { get; set; }
    }

    /// <summary>
    /// DTO cho doanh thu theo tuần (Bar Chart)
    /// </summary>
    public class WeeklyRevenueDTO
    {
        public string WeekLabel { get; set; } = "";
        public double Revenue { get; set; }
    }

    /// <summary>
    /// DTO cho báo cáo doanh thu theo ngày
    /// </summary>
    public class DailyRevenueDTO
    {
        public string Ngay { get; set; } = "";
        public int SoDon { get; set; }
        public decimal DoanhThu { get; set; }
    }

    /// <summary>
    /// DTO cho KPI tổng hợp báo cáo
    /// </summary>
    public class ReportKpiDTO
    {
        public int SoDon { get; set; }
        public decimal TongDoanhThu { get; set; }
        public decimal GiaTriTB { get; set; }
    }
}
