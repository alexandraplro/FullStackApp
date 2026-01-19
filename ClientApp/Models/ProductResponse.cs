namespace ClientApp.Models
{
    /// Wrapper model used to deserialize the JSON response returned by the back-end API.
    /// Copilot recommended introducing this class during Activity 3 to match the API's updated structure, which returns a 'products' array inside a parent object.
    public class ProductResponse
    {
        /// Collection of products returned from the API.
        /// Copilot suggested initializing this property with Array.Empty to avoid null-reference issues in the Blazor front-end during deserialization.
        public Product[] Products { get; set; } = Array.Empty<Product>();
    }
}
