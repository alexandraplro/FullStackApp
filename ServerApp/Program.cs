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

            // Register EF Core with InMemory provider
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite("Data Source=inventory.db"));

            // Register controllers (REQUIRED for EF migrations + your API controllers)
            builder.Services.AddControllers();

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

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseCors();

            app.UseSwagger();
            app.UseSwaggerUI();

            // Map controllers (REQUIRED)
            app.MapControllers();

            // Minimal API endpoints (optional)
            var products = SeedData.GetProducts();

            app.MapGet("/api/products", () => Results.Ok(products));

            app.MapGet("/api/products/sorted", (string sortBy) =>
            {
                IEnumerable<Product> sorted = sortBy.ToLower() switch
                {
                    "price" => products.OrderBy(p => p.Price),
                    "name" => products.OrderBy(p => p.Name),
                    "stock" => products.OrderByDescending(p => p.Stock),
                    "date" => products.OrderByDescending(p => p.DateAdded),
                    _ => products
                };

                return Results.Ok(sorted);
            });

            app.Run();
        }
    }
}
