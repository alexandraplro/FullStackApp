using System.ComponentModel.DataAnnotations;

namespace ServerApp.Models
{
    public class LossRecord
    {
        [Required]
        public int Id { get; set; } = 0;
        [Required]
        public DateTime Date { get; set; }  = DateTime.MinValue;
        [Required]
        public int ProductId { get; set; } = 0;
        [Required]
        public int Quantity { get; set; } = 0;
        [Required]
        public string Reason { get; set; } = string.Empty;
        [Required]
        public decimal TotalValue { get; set; } = 0m;
    }
}
