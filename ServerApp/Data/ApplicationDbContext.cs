using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<SalesRecord> SaleRecords { get; set; }
        public DbSet<LossRecord> LossRecords { get; set; }
        public DbSet<DeliveryRecord> DeliveryRecords { get; set; }
    }
}
