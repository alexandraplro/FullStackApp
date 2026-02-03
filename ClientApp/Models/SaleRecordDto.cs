using System;
using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class SaleRecordDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public ProductDto? Product { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
