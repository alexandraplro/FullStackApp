using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class Delivery
    {
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string Supplier { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;
    }
}
