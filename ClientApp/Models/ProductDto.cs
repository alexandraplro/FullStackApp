using System;
using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Stock { get; set; }
    }
}
