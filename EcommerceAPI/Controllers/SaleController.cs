using EcommerceAPI.Model;
using EcommerceAPI.DatabaseContext;
using Microsoft.AspNetCore.Mvc;

// public ICollection<Product> Products { get; set; } => tabela Sale

namespace EcommerceAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public SaleController(EcommerceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetSales()
        {
            var allSales = _context.Sales.ToList();

            if (allSales.Any())
            {
                return Ok(allSales);
            } 
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public IActionResult CreateSales(int productId, int userId)
        {
            var product = _context.Products.Find(productId);
            var user = _context.Users.Find(userId);
            
            Sale sale = new Sale();

            if (product == null || user == null)
            {
                return NotFound();
            }
            else
            {
                sale.UserId = user.Id;
                sale.ProductId = product.Id;

                _context.Sales.Add(sale);
                _context.SaveChanges();
            }

            return Ok(sale);
        }



      
    }
}
