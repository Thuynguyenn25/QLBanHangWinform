namespace QLBanHang.DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public string OrderDate { get; set; } = "";
        public string CustomerName { get; set; } = "";
        public string Phone { get; set; } = "";
        public decimal TotalAmount { get; set; }
    }
}
