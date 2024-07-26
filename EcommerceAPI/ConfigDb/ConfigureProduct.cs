using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.ConfigDb
{
    public class ConfigureProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entityProduct)
        {
            entityProduct.HasKey(p => p.ProductId);

            entityProduct.HasMany(s => s.Sales)
                .WithMany(p => p.Products);
        }
    }
}
