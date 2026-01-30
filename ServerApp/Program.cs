using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ServerApp.Models;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;

namespace ServerApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase("ApplicationDbContext"));


            // Enable CORS for the Blazor client
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            // Add Swagger for API documentation (optional but great for portfolio)
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseCors();

            // Enable Swagger UI
            app.UseSwagger();
            app.UseSwaggerUI();

            // Generate 100 seeded products
            var products = SeedData.GetProducts();

            // GET: Return all products
            app.MapGet("/api/products", () =>
            {
                return Results.Ok(products);
            });

            // GET: Sorted products (optional)
            app.MapGet("/api/products/sorted", (string sortBy) =>
            {
                IEnumerable<Product> sorted = sortBy.ToLower() switch
                {
                    "price" => products.OrderBy(p => p.Price),
                    "name" => products.OrderBy(p => p.Name),
                    "stock" => products.OrderByDescending(p => p.Stock),
                    "date" => products.OrderByDescending(p => p.DateAdded),
                    _   => products
                };
            
            return Results.Ok(sorted);
            });

            app.Run();
        }
    }
}
