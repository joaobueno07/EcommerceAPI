using EcommerceAPI.Model;
using EcommerceAPI.DatabaseContext;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult CreateSale(Sale sale)
        {
            var products = _context.Products;
            var users = _context.Users;

           

            return Ok(sale);
        }
    }
}
