using System.ComponentModel.DataAnnotations;

namespace UniMartAPI.DTOs.Product
{
    public class CreateProductDto
    {
        [Required]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }
        [MaxLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        public string? Description { get; set; }

        [Range(1, 10000000, ErrorMessage = "Price must be between 1 and 10,000,000")]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Invalid category")]
        public int CategoryId { get; set; }
    }
}
