using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace QLBanHang.DAL
{
    public class OrderDAL
    {
        public int Insert(OrderDTO order)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery(
                    "INSERT INTO Orders(OrderDate, CustomerName, Phone, TotalAmount) VALUES(@date, @name, @phone, @total);",
                    new SQLiteParameter("@date", order.OrderDate),
                    new SQLiteParameter("@name", order.CustomerName),
                    new SQLiteParameter("@phone", order.Phone),
                    new SQLiteParameter("@total", order.TotalAmount));

                DataTable dtId = sql.ExecuteQuery("SELECT MAX(OrderId) AS OrderId FROM Orders;");
                if (dtId.Rows.Count > 0)
                    return Convert.ToInt32(dtId.Rows[0]["OrderId"]);
            }
            catch (Exception ex) { Utils.Log("OrderDAL.Insert", ex); }
            return -1;
        }

        public OrderDTO? GetById(int orderId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT OrderDate, CustomerName, Phone, TotalAmount FROM Orders WHERE OrderId = @id LIMIT 1;",
                    new SQLiteParameter("@id", orderId));
                if (dt.Rows.Count > 0)
                {
                    var r = dt.Rows[0];
                    return new OrderDTO
                    {
                        OrderId = orderId,
                        OrderDate = r["OrderDate"]?.ToString() ?? "",
                        CustomerName = r["CustomerName"]?.ToString() ?? "",
                        Phone = r["Phone"]?.ToString() ?? "",
                        TotalAmount = Convert.ToDecimal(r["TotalAmount"])
                    };
                }
            }
            catch (Exception ex) { Utils.Log("OrderDAL.GetById", ex); }
            return null;
        }

        public List<string> GetDistinctCustomerNames()
        {
            var list = new List<string>();
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT DISTINCT CustomerName FROM Orders WHERE CustomerName IS NOT NULL AND TRIM(CustomerName) <> '' ORDER BY CustomerName;");
                foreach (DataRow r in dt.Rows) list.Add(r["CustomerName"].ToString() ?? "");
            }
            catch (Exception ex) { Utils.Log("OrderDAL.GetDistinctCustomerNames", ex); }
            return list;
        }

        public List<string> GetDistinctPhones()
        {
            var list = new List<string>();
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT DISTINCT Phone FROM Orders WHERE Phone IS NOT NULL AND TRIM(Phone) <> '' ORDER BY Phone;");
                foreach (DataRow r in dt.Rows) list.Add(r["Phone"].ToString() ?? "");
            }
            catch (Exception ex) { Utils.Log("OrderDAL.GetDistinctPhones", ex); }
            return list;
        }

        public DashboardKpiDTO GetDashboardKpi(int lowStockThreshold)
        {
            var kpi = new DashboardKpiDTO { LowStockThreshold = lowStockThreshold };
            try
            {
                string today = DateTime.Today.ToString("yyyy-MM-dd");
                string yesterday = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                var sql = new Data.SQLiteUtils();

                DataTable dtToday = sql.ExecuteQuery(
                    $"SELECT COUNT(*) AS SoDon, COALESCE(SUM(TotalAmount), 0) AS DoanhThu FROM Orders WHERE OrderDate LIKE '{today}%';");
                DataTable dtY = sql.ExecuteQuery(
                    $"SELECT COALESCE(SUM(TotalAmount), 0) AS DoanhThu FROM Orders WHERE OrderDate LIKE '{yesterday}%';");
                DataTable dtLow = sql.ExecuteQuery(
                    "SELECT COUNT(*) AS SoSP FROM Products WHERE IsActive = 1 AND Stock <= @th;",
                    new SQLiteParameter("@th", lowStockThreshold));

                if (dtToday.Rows.Count > 0)
                {
                    kpi.SoDonToday = Convert.ToInt32(dtToday.Rows[0]["SoDon"]);
                    kpi.DoanhThuToday = Convert.ToDecimal(dtToday.Rows[0]["DoanhThu"]);
                }
                if (dtY.Rows.Count > 0) kpi.DoanhThuYesterday = Convert.ToDecimal(dtY.Rows[0]["DoanhThu"]);
                if (dtLow.Rows.Count > 0) kpi.LowStockCount = Convert.ToInt32(dtLow.Rows[0]["SoSP"]);
            }
            catch (Exception ex) { Utils.Log("OrderDAL.GetDashboardKpi", ex); }
            return kpi;
        }

        public List<WeeklyRevenueDTO> GetWeeklyRevenue(int weeks)
        {
            var list = new List<WeeklyRevenueDTO>();
            try
            {
                int days = weeks * 7 - 1;
                string q = $@"SELECT strftime('%Y', OrderDate) || '-W' || strftime('%W', OrderDate) AS Tuan,
                    COALESCE(SUM(TotalAmount), 0) AS DoanhThu FROM Orders
                    WHERE date(OrderDate) >= date('now', '-{days} day')
                    GROUP BY strftime('%Y', OrderDate), strftime('%W', OrderDate)
                    ORDER BY strftime('%Y', OrderDate), strftime('%W', OrderDate);";
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(q);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new WeeklyRevenueDTO
                    {
                        WeekLabel = r["Tuan"].ToString() ?? "",
                        Revenue = Convert.ToDouble(r["DoanhThu"])
                    });
                }
            }
            catch (Exception ex) { Utils.Log("OrderDAL.GetWeeklyRevenue", ex); }
            return list;
        }

        public List<DailyRevenueDTO> GetDailyRevenue(string fromStr, string toStr)
        {
            var list = new List<DailyRevenueDTO>();
            try
            {
                string q = $@"SELECT date(OrderDate) AS Ngay, COUNT(*) AS SoDon, COALESCE(SUM(TotalAmount),0) AS DoanhThu
                    FROM Orders WHERE OrderDate >= '{fromStr}' AND OrderDate <= '{toStr}'
                    GROUP BY date(OrderDate) ORDER BY date(OrderDate) DESC;";
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(q);
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new DailyRevenueDTO
                    {
                        Ngay = r["Ngay"].ToString() ?? "",
                        SoDon = Convert.ToInt32(r["SoDon"]),
                        DoanhThu = Convert.ToDecimal(r["DoanhThu"])
                    });
                }
            }
            catch (Exception ex) { Utils.Log("OrderDAL.GetDailyRevenue", ex); }
            return list;
        }

        public ReportKpiDTO GetReportKpi(string fromStr, string toStr)
        {
            var kpi = new ReportKpiDTO();
            try
            {
                string q = $@"SELECT COUNT(*) AS SoDon, COALESCE(SUM(TotalAmount), 0) AS TongDoanhThu,
                    CASE WHEN COUNT(*) = 0 THEN 0 ELSE (COALESCE(SUM(TotalAmount), 0) * 1.0 / COUNT(*)) END AS GiaTriTB
                    FROM Orders WHERE OrderDate >= '{fromStr}' AND OrderDate <= '{toStr}';";
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(q);
                if (dt.Rows.Count > 0)
                {
                    kpi.SoDon = Convert.ToInt32(dt.Rows[0]["SoDon"]);
                    kpi.TongDoanhThu = Convert.ToDecimal(dt.Rows[0]["TongDoanhThu"]);
                    kpi.GiaTriTB = Convert.ToDecimal(dt.Rows[0]["GiaTriTB"]);
                }
            }
            catch (Exception ex) { Utils.Log("OrderDAL.GetReportKpi", ex); }
            return kpi;
        }
    }
}
