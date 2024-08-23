using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.ConfigDb
{
    public class ConfigureProduct : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entityProduct)
        {
            entityProduct.HasKey(p => p.Id);
            entityProduct.Property(p => p.Id).ValueGeneratedOnAdd();

            entityProduct.Property(p => p.Name).IsRequired();
            entityProduct.Property(p => p.Price).IsRequired();
            
        }
    }
}
