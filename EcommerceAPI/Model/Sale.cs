namespace EcommerceAPI.Model
{
    public class Sale
    {
        public string SaleId { get; set; }
        public User UserClient { get; set; }
        public int UserId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime PurchaseTime { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
