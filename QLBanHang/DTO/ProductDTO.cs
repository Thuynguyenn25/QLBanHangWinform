namespace QLBanHang.DTO
{
    public class ProductDTO
    {
        public string ProductID { get; set; } = "";
        public string Name { get; set; } = "";
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int IsActive { get; set; } = 1;
    }
}
