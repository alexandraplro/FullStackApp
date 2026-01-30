using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class DeliveryRecord
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
        public decimal Price { get; set; } = 0m;
        [Required]
        public decimal Total { get; set; } = 0m;
    }
}