using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApp.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [StringLength(500, MinimumLength = 10)]
        public string? Message { get; set; }
    }
}