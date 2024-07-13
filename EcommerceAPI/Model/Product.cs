using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Model
{
    public class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        [Key]
        public string Id { get; set; }
        public int Quantity { get; set; }
    }
}
