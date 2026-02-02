using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DeliveriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/deliveries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Delivery>>> GetDeliveries()
        {
            var deliveries = await _context.Deliveries
                .Include(d => d.Product)
                .OrderByDescending(d => d.Date)
                .ToListAsync();

            return Ok(deliveries);
        }

        // POST: api/deliveries
        [HttpPost]
        public async Task<ActionResult<Delivery>> CreateDelivery(Delivery delivery)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await _context.Products.FindAsync(delivery.ProductId);
            if (product == null)
                return BadRequest("Invalid product ID.");

            if (delivery.Quantity <= 0)
                return BadRequest("Quantity must be greater than zero.");

            // Increase stock
            product.Stock += delivery.Quantity;

            _context.Deliveries.Add(delivery);
            await _context.SaveChangesAsync();

            // Return delivery with product info
            await _context.Entry(delivery).Reference(d => d.Product).LoadAsync();

            return Ok(delivery);
        }
    }
}
