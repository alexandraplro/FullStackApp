    
using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{    
    public class SalesRecord
    {
        [Required]
        public int Id { get; set; } = 0;
        [Required]
        public DateTime Date { get; set; } = DateTime.MinValue;
        [Required]
        public int ProductId { get; set; } = 0;
        [Required]
        public int Quantity { get; set; } = 0;
        [Required]
        public string TaxLocation { get; set; } = string.Empty;
        [Required]
        public string ShipmentType { get; set; } = string.Empty;
        [Required]
        public decimal Total { get; set; } = 0m;

        // Navigation property 
        public Product? Product { get; set; }
    }
}
