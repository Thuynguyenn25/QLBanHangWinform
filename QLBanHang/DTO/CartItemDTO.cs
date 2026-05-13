namespace QLBanHang.DTO
{
    public class CartItemDTO
    {
        public string ProductId { get; set; } = "";
        public string ProductName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal LineTotal
        {
            get { return Quantity * UnitPrice; }
        }
    }
}
