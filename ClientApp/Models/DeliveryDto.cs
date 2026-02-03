using System;
using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class DeliveryDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public ProductDto? Product { get; set; }
        public int Quantity { get; set; }
        public string Supplier { get; set; } = "";
        public string Notes { get; set; } = "";
    }
}
