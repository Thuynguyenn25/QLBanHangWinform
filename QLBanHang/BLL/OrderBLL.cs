using QLBanHang.DAL;
using QLBanHang.DTO;
using System;
using System.Collections.Generic;

namespace QLBanHang.BLL
{
    public class OrderBLL
    {
        private readonly OrderDAL _orderDal = new OrderDAL();
        private readonly OrderDetailDAL _detailDal = new OrderDetailDAL();
        private readonly ProductDAL _productDal = new ProductDAL();

        public OrderDTO? GetOrderById(int orderId) => _orderDal.GetById(orderId);

        public List<OrderDetailDTO> GetOrderDetails(int orderId) => _detailDal.GetByOrderId(orderId);

        public List<string> GetDistinctCustomerNames() => _orderDal.GetDistinctCustomerNames();

        public List<string> GetDistinctPhones() => _orderDal.GetDistinctPhones();

        public DashboardKpiDTO GetDashboardKpi(int lowStockThreshold = 5) => _orderDal.GetDashboardKpi(lowStockThreshold);

        public List<WeeklyRevenueDTO> GetWeeklyRevenue(int weeks = 4) => _orderDal.GetWeeklyRevenue(weeks);

        public List<DailyRevenueDTO> GetDailyRevenue(DateTime from, DateTime to)
        {
            string fromStr = from.ToString("yyyy-MM-dd HH:mm:ss");
            string toStr = to.ToString("yyyy-MM-dd HH:mm:ss");
            return _orderDal.GetDailyRevenue(fromStr, toStr);
        }

        public ReportKpiDTO GetReportKpi(DateTime from, DateTime to)
        {
            string fromStr = from.ToString("yyyy-MM-dd HH:mm:ss");
            string toStr = to.ToString("yyyy-MM-dd HH:mm:ss");
            return _orderDal.GetReportKpi(fromStr, toStr);
        }

        /// <summary>
        /// Đặt hàng: tạo order, tạo order details, trừ tồn kho
        /// </summary>
        public (bool success, string message, int orderId) PlaceOrder(string customerName, string phone, List<CartItemDTO> cart)
        {
            if (cart == null || cart.Count == 0)
                return (false, "Giỏ hàng đang trống!", -1);

            if (string.IsNullOrWhiteSpace(customerName))
                return (false, "Vui lòng nhập tên khách hàng!", -1);

            // Kiểm tra tồn kho trước
            foreach (var item in cart)
            {
                var info = _productDal.GetActiveProductInfo(item.ProductId);
                if (info == null)
                    return (false, $"Sản phẩm {item.ProductName} không còn bán!", -1);
                if (item.Quantity > info.Stock)
                    return (false, $"Không đủ tồn kho cho sản phẩm {item.ProductName}. Tồn: {info.Stock}, cần: {item.Quantity}", -1);
            }

            decimal totalAmount = 0;
            foreach (var item in cart) totalAmount += item.LineTotal;

            var order = new OrderDTO
            {
                OrderDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                CustomerName = customerName,
                Phone = phone,
                TotalAmount = totalAmount
            };

            int orderId = _orderDal.Insert(order);
            if (orderId < 0)
                return (false, "Tạo đơn hàng thất bại!", -1);

            foreach (var item in cart)
            {
                var detail = new OrderDetailDTO
                {
                    OrderId = orderId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice,
                    LineTotal = item.LineTotal
                };
                _detailDal.Insert(detail);
                _productDal.ReduceStock(item.ProductId, item.Quantity);
            }

            return (true, $"Đặt hàng thành công! Mã hóa đơn: {orderId}", orderId);
        }
    }
}
