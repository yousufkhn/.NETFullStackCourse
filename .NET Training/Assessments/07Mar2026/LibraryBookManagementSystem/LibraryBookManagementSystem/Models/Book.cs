using System.ComponentModel.DataAnnotations;

namespace LibraryBookManagementSystem.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
