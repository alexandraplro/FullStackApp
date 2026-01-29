namespace ClientApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; } = new();
        public string SKU { get; set; } = string.Empty;
        public string Supplier { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public bool IsActive { get; set; }
        public int ReorderLevel { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
