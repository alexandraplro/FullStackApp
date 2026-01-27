using System;

namespace ServerApp.Models
{
    /// <summary>
    /// Represents a product stored in the inventory and returned by the API.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Unique identifier for the product.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Human-readable product name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Price of the product.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Quantity available in stock.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Category information for the product.
        /// </summary>
        public Category Category { get; set; } = new Category();

        /// <summary>
        /// Unique SKU code for inventory tracking.
        /// </summary>
        public string SKU { get; set; } = string.Empty;

        /// <summary>
        /// Supplier or vendor name.
        /// </summary>
        public string Supplier { get; set; } = string.Empty;

        /// <summary>
        /// Date the product was added to the inventory.
        /// </summary>
        public DateTime DateAdded { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Indicates whether the product is active in the inventory.
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Minimum stock level before triggering a reorder.
        /// </summary>
        public int ReorderLevel { get; set; } = 10;

        public string ImageUrl { get; set; } = string.Empty;

    }
}
