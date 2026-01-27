namespace ServerApp.Models
{
    /// <summary>
    /// Represents a product category in the inventory system.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Unique identifier for the category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Human-readable category name (e.g., Electronics, Accessories).
        /// </summary>
        public string Name { get; set; } = string.Empty;
    }
}
