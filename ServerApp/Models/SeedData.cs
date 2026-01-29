using System;
using System.Collections.Generic;
using System.Linq;

using System;
using System.Collections.Generic;

namespace ServerApp.Models
{
    public static class SeedData
    {
        private static readonly Random rnd = new();

        private static readonly Dictionary<string, string[]> ProductNames = new()
        {
            ["Electronics"] = new[]
            {
                "Bluetooth Noise-Canceling Headphones",
                "10,000mAh Portable Charger",
                "Smart Home Hub",
                "USB-C Fast Charger",
                "Wireless Router AX3000",
                "External SSD 1TB",
                "4K Streaming Device",
                "Smart LED Light Bulb",
                "Bluetooth Speaker Mini",
                "USB-C Docking Station",
                "Wireless Charging Pad",
                "1080p Webcam Pro",
                "Digital Alarm Clock",
                "Smart Thermostat",
                "Portable Bluetooth Keyboard"
            },

            ["Accessories"] = new[]
            {
                "Stainless Steel Water Bottle",
                "Insulated Travel Mug",
                "Compact Umbrella",
                "RFID-Blocking Wallet",
                "Canvas Tote Bag",
                "Leather Key Organizer",
                "Portable Power Bank",
                "Foldable Shopping Bag",
                "Reusable Lunch Container",
                "Multi-Tool Pocket Knife",
                "Travel Toiletry Kit",
                "Reusable Straw Set"
            },

            ["Office"] = new[]
            {
                "Gel Ink Pen Pack",
                "Spiral Notebook A5",
                "Adjustable Desk Lamp",
                "Wireless Keyboard & Mouse Set",
                "Laminated File Folders",
                "Desktop Organizer Tray",
                "Whiteboard Marker Set",
                "Heavy-Duty Stapler",
                "Ergonomic Office Chair",
                "Monitor Riser Stand",
                "Document Scanner Compact",
                "Desk Mat Leather"
            },

            ["Kitchen"] = new[]
            {
                "Stainless Steel Cookware Set",
                "Ceramic Coffee Mug",
                "Bamboo Cutting Board",
                "Non-Stick Frying Pan",
                "Glass Food Storage Set",
                "Electric Kettle",
                "Silicone Spatula Set",
                "Reusable Baking Mat",
                "Kitchen Scale Digital",
                "Vacuum-Sealed Storage Bags",
                "Stainless Steel Mixing Bowls",
                "Chef’s Knife 8-inch"
            },

            ["Outdoor"] = new[]
            {
                "2-Person Camping Tent",
                "Lightweight Hiking Backpack",
                "Portable Propane Stove",
                "LED Camping Lantern",
                "Thermal Sleeping Bag",
                "Collapsible Trekking Poles",
                "Waterproof Dry Bag",
                "Handheld GPS Unit",
                "Solar-Powered Charger",
                "Emergency First Aid Kit",
                "Outdoor Folding Chair",
                "Portable Water Filter"
            },

            ["Apparel"] = new[]
            {
                "Cotton Crewneck T-Shirt",
                "Waterproof Hiking Jacket",
                "Thermal Socks Pack",
                "Running Shorts Lightweight",
                "Fleece Hoodie",
                "Baseball Cap Adjustable",
                "Winter Beanie Wool",
                "Athletic Compression Shirt",
                "Rain Poncho Compact",
                "Leather Belt Classic",
                "Sunglasses UV-Protection",
                "Canvas Sneakers"
            },

            ["Gaming"] = new[]
            {
                "Wireless Gaming Headset",
                "RGB Mechanical Keyboard",
                "High-Precision Gaming Mouse",
                "27\" 144Hz Gaming Monitor",
                "Console Controller Charging Dock",
                "Gaming Mouse Pad XL",
                "USB Streaming Microphone",
                "VR Motion Controllers",
                "Capture Card HD",
                "Gaming Chair with Lumbar Support",
                "RGB Light Strip",
                "Gaming Console Stand"
            },

            ["Fitness"] = new[]
            {
                "Yoga Mat Non-Slip",
                "Adjustable Dumbbell Set",
                "Resistance Bands Pack",
                "Foam Roller High-Density",
                "Stainless Steel Shaker Bottle",
                "Jump Rope Speed Training",
                "Fitness Tracker Wristband",
                "Exercise Ball Stability",
                "Kettlebell 20lb",
                "Pull-Up Bar Doorway",
                "Workout Gloves Padded",
                "Ankle Weights Adjustable"
            }
        };

        private static readonly string[] Suppliers = new[]
        {
            "GlobalTech Distribution",
            "Northwind Traders",
            "Contoso Retail Supply",
            "Fabrikam Industrial",
            "AdventureWorks Outdoors",
            "Evergreen Essentials",
            "Summit Gear Co.",
            "Horizon Electronics",
            "Urban Office Supply",
            "PureKitchen Brands"
        };

        public static List<Product> GetProducts()
        {
            var products = new List<Product>();

            for (int i = 1; i <= 100; i++)
            {
                var categoryName = GetRandomCategory();
                var productName = GetRandomProductName(categoryName);

                var category = new Category
                {
                    Id = rnd.Next(100, 999),
                    Name = categoryName
                };

                var product = new Product
                {
                    Id = i,
                    Name = productName,
                    Price = Math.Round(rnd.NextDouble() * 200 + 10, 2),
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

        private static string GetRandomCategory()
        {
            var keys = new List<string>(ProductNames.Keys);
            return keys[rnd.Next(keys.Count)];
        }

        private static string GetRandomProductName(string category)
        {
            var list = ProductNames[category];
            return list[rnd.Next(list.Length)];
        }
    }
}
