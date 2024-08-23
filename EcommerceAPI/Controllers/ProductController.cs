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

        [HttpGet]
        public IActionResult GetProducts()
        {
            var allProducts = _context.Products.ToList();
            return Ok(allProducts);
        }
        
        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            if (product.Name != null && product.Price != null)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }

            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var productToUpdate = _context.Products.Find(id);

            if (productToUpdate == null)
            {
                return NotFound();
            }

            productToUpdate.Name = product.Name;
            productToUpdate.Id = product.Id;
            productToUpdate.Price = product.Price;
            productToUpdate.Quantity = product.Quantity;
            productToUpdate.Category = product.Category;

            _context.Products.Update(productToUpdate);
            _context.SaveChanges(); // tratar erro

            return Ok(productToUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var productId = _context.Products.Find(id);

            if (productId == null)
            {
                return NotFound();
            }

            _context.Products.Remove(productId);
            _context.SaveChanges();

            return Ok(productId);
        }
    }
}
