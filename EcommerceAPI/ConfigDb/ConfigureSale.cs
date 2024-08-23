using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.ConfigDb
{
    public class ConfigureSale : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> entitySale)
        {
            entitySale.HasKey(s => s.Id);
            entitySale.Property(s => s.Id).ValueGeneratedOnAdd();
        }
    }
}
