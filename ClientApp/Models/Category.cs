namespace ClientApp.Models
{
    /// Represents the category information associated with a product.
    public class Category
    {
        /// Unique identifier for the category.
        /// Copilot recommended using a simple 'Id' property to align with standard JSON conventions and ensure smooth deserialization.
        public int Id { get; set; }

        /// Human-readable name of the category (e.g., Electronics, Accessories).
        /// Copilot suggested initializing this property with an empty string to avoid null-reference issues in the Blazor front-end.
        public string Name { get; set; } = string.Empty;
    }
}
