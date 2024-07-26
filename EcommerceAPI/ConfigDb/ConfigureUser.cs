using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.ConfigDb
{
    public class ConfigureUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entityUser)
        {
            entityUser.HasKey(u => u.UserId);

            entityUser.HasMany(p => p.UserSales)
                .WithOne(u => u.UserClient)
                .HasForeignKey(fk => fk.UserId);
        }
    }
}
