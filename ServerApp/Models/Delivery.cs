using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class Delivery
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        public int ProductId { get; set; } = 0;
        [Required]
        public Product Product { get; set; } = null!;
        [Required]
        public int Quantity { get; set; } = 0;
        [Required]
        public string Supplier { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
}
