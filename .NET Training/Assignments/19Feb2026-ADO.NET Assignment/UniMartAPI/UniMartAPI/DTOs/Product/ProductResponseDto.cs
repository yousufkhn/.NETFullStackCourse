namespace UniMartAPI.DTOs.Product
{
    public class ProductResponseDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string SellerName { get; set; }
        public string SellerPhone { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
