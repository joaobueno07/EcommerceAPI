using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Model
{
    public class Product 
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
