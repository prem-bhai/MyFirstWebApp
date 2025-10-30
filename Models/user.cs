using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace MyFirstWebApp.Models
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Correct navigation property — refers to Models.CartItem
        public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
