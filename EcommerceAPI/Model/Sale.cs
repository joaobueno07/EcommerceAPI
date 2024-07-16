

namespace EcommerceAPI.Model
{
    public class Sale
    {
        public User UserClient { get; set; }
        public string SaleId { get; set; }
        public int Quantity { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
