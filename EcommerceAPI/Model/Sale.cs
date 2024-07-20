namespace EcommerceAPI.Model
{
    public class Sale
    {
        public string SaleId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public double TotalPrice { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
