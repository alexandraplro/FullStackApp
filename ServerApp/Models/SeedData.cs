using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerApp.Models
{
    /// <summary>
    /// Generates a seeded list of products for the inventory system.
    /// </summary>
    public static class SeedData
    {
        private static readonly string[] Categories = new[]
        {
            "Electronics", "Accessories", "Office", "Kitchen",
            "Outdoor", "Apparel", "Gaming", "Fitness"
        };

        private static readonly string[] Suppliers = new[]
        {
            "GlobalTech", "SupplyCo", "Northwind Traders",
            "Contoso Retail", "Fabrikam Goods", "AdventureWorks"
        };

        /// <summary>
        /// Generates a list of 100 products with randomized values.
        /// </summary>
        public static List<Product> GetProducts()
        {
            var rnd = new Random();
            var products = new List<Product>();

            for (int i = 1; i <= 100; i++)
            {
                var categoryName = Categories[rnd.Next(Categories.Length)];
                var category = new Category
                {
                    Id = rnd.Next(100, 999),
                    Name = categoryName
                };

                var product = new Product
                {
                    Id = i,
                    Name = $"{categoryName} Item {i}",
                    Price = Math.Round(rnd.NextDouble() * 500 + 10, 2),
                    Stock = rnd.Next(0, 200),
                    Category = category,
                    SKU = $"SKU-{i:D5}",
                    Supplier = Suppliers[rnd.Next(Suppliers.Length)],
                    DateAdded = DateTime.UtcNow.AddDays(-rnd.Next(0, 365)),
                    IsActive = rnd.Next(0, 2) == 1,
                    ReorderLevel = rnd.Next(5, 25),
                    ImageUrl = $"/images/icons/{categoryName.ToLower()}.png"
                };

                products.Add(product);
            }

            return products;
        }
    }
}
