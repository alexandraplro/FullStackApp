using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; } = 0;
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; } = 0m;
        [Required]
        public int Stock { get; set; } = 0;
        [Required]
        public Category Category { get; set; } = new();
        [Required]
        public string SKU { get; set; } = string.Empty;
        [Required]
        public string Supplier { get; set; } = string.Empty;
        [Required]
        public DateTime DateAdded { get; set; } = DateTime.MinValue;
        [Required]
        public bool IsActive { get; set; } = true;
        [Required]
        public int ReorderLevel { get; set; } = 0;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
