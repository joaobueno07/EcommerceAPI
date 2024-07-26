using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.ConfigDb
{
    public class ConfigureSale : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> entitySale)
        {
            entitySale.HasKey(s => s.SaleId);

            entitySale.HasOne(u => u.UserClient)
                .WithMany(u => u.UserSales)
                .HasForeignKey(fk => fk.UserId);
        }
    }
}
