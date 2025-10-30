using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFirstWebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        // ✅ Correct decimal precision
        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, 999999.99, ErrorMessage = "Price must be between 0.01 and 999999.99")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(100)]
        public string? Category { get; set; }

        public string? ImageUrl { get; set; }

        public int StockQuantity { get; set; } = 0;

        // ✅ Add navigation property for related cart items
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
