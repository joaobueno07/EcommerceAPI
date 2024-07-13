using EcommerceAPI.DatabaseContext;
using EcommerceAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly EcommerceContext _context;

        public ProductController(EcommerceContext context)
        {
            _context = context;
        }

        
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var allProducts = _context.Products.ToList();
            return Ok(allProducts);
        }

       
        // criar o método UpdateProduct

        [HttpDelete]
        public IActionResult DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok(product);
        }
    }
}
