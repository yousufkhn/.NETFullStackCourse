using System.ComponentModel.DataAnnotations;

namespace UniMartAPI.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(100,MinimumLength =2)]
        [RegularExpression(@"^[a-zA-Z\s'-]+$", ErrorMessage = "Name can only contain letters, spaces, hyphens, and apostrophes")]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [RegularExpression(@"^\+?[0-9]{10,15}$", ErrorMessage = "Enter a valid phone number (10-15 digits)")]
        public string PhoneNumber { get; set; }
    }
}
