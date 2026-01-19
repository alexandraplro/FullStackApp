namespace ClientApp.Models
{
    /// Represents a product returned by the back-end API.
    public class Product
    {
        /// Unique identifier for the product.
        /// Copilot confirmed that this property should match the 'id' field in the JSON response to ensure correct deserialization.
        public int Id { get; set; }

        /// Human-readable product name.
        /// Copilot suggested initializing this property with an empty string to prevent null-reference issues in the Blazor UI.
        public string Name { get; set; } = string.Empty;

        /// Price of the product.
        /// Copilot helped validate that using 'double' aligns with the numeric format returned by the Minimal API.
        public double Price { get; set; }


        /// Quantity of the product available in stock.
        /// This property was included based on Copilot's guidance to mirror the structure of the API's JSON payload.
        public int Stock { get; set; }

        /// Category information for the product.
        /// Copilot recommended adding this nested object to match the updated
        public Category Category { get; set; } = new Category();
    }
}
