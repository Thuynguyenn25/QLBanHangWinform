using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace QLBanHang.DAL
{
    public class OrderDetailDAL
    {
        public bool Insert(OrderDetailDTO detail)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery(
                    "INSERT INTO OrderDetails(OrderId, ProductId, Quantity, UnitPrice, LineTotal) VALUES(@orderId, @prodId, @qty, @price, @total);",
                    new SQLiteParameter("@orderId", detail.OrderId),
                    new SQLiteParameter("@prodId", detail.ProductId),
                    new SQLiteParameter("@qty", detail.Quantity),
                    new SQLiteParameter("@price", detail.UnitPrice),
                    new SQLiteParameter("@total", detail.LineTotal));
                return true;
            }
            catch (Exception ex) { Utils.Log("OrderDetailDAL.Insert", ex); return false; }
        }

        public List<OrderDetailDTO> GetByOrderId(int orderId)
        {
            var list = new List<OrderDetailDTO>();
            try
            {
                string q = @"SELECT od.ProductId, p.Name AS ProductName, od.Quantity, od.UnitPrice, od.LineTotal
                    FROM OrderDetails od JOIN Products p ON p.ProductId = od.ProductId WHERE od.OrderId = @id;";
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(q, new SQLiteParameter("@id", orderId));
                foreach (DataRow r in dt.Rows)
                {
                    list.Add(new OrderDetailDTO
                    {
                        OrderId = orderId,
                        ProductId = r["ProductId"].ToString() ?? "",
                        ProductName = r["ProductName"].ToString() ?? "",
                        Quantity = Convert.ToInt32(r["Quantity"]),
                        UnitPrice = Convert.ToDecimal(r["UnitPrice"]),
                        LineTotal = Convert.ToDecimal(r["LineTotal"])
                    });
                }
            }
            catch (Exception ex) { Utils.Log("OrderDetailDAL.GetByOrderId", ex); }
            return list;
        }
    }
}
