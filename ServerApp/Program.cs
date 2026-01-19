using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ServerApp 
{
    /// Static class holding cached product data.
    /// Copilot recommended using a static class to ensure the product list is created once and reused across all API requests, improving performance.
    public static class ProductData
    {
        public static readonly object ProductCache = new
        {
            products = new[]
            {
                new
                {
                    id = 1,
                    name = "Laptop",
                    price = 1200.50,
                    stock = 25,
                    category = new { id = 101, name = "Electronics" }
                },
                new
                {
                    id = 2,
                    name = "Headphones",
                    price = 50.00,
                    stock = 100,
                    category = new { id = 102, name = "Accessories" }
                }
            }
        };
    }

    /// Program class hosting the Minimal API.
    /// Copilot assisted in structuring this file to ensure correct routing, CORS configuration, and JSON response formatting for Activity 1–3.
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Registers CORS services.
            // Copilot recommended adding a default policy that allows any origin, method, and header to resolve the CORS errors encountered during Activity 2.
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            // Applies the CORS middleware.
            // Copilot helped identify the correct placement of this middleware to ensure the browser receives the Access-Control-Allow-Origin header.
            app.UseCors();

            // Defines the /api/productlist endpoint.
            // Copilot assisted in shaping the nested JSON structure returned here and recommended returning the cached object to reduce server load.
            app.MapGet("/api/productlist", () =>
            {
                return ProductData.ProductCache;
            });

            // Starts the Minimal API application.
            // Copilot confirmed that no additional middleware was required.
            app.Run();
        }
    }
}
