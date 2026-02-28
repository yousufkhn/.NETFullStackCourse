using System.ComponentModel.DataAnnotations;

namespace UniMartAPI.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new();
    }
}
