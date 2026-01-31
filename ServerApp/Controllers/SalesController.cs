using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SalesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/sales
        [HttpGet]
        public async Task<IActionResult> GetSales()
        {
            var sales = await _context.SaleRecords
                .Include(s => s.Product)
                .OrderByDescending(s => s.Date)
                .ToListAsync();

            return Ok(sales);
        }

        // POST: api/sales
        [HttpPost]
        public async Task<IActionResult> CreateSale([FromBody] SalesRecord sale)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Update product stock
            var product = await _context.Products.FindAsync(sale.ProductId);
            if (product == null)
                return NotFound("Product not found");

            if (product.Stock < sale.Quantity)
                return BadRequest("Not enough stock");

            product.Stock -= sale.Quantity;

            // Calculate total
            sale.Total = (decimal)(product.Price * sale.Quantity);

            _context.SaleRecords.Add(sale);
            await _context.SaveChangesAsync();

            return Ok(sale);
        }
    }
}
