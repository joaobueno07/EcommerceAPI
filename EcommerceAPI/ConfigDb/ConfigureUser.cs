using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.ConfigDb
{
    public class ConfigureUser : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entityUser)
        {
            entityUser.HasKey(u => u.Id);
            entityUser.Property(u => u.Id).ValueGeneratedOnAdd();

            entityUser.Property(u => u.Name).IsRequired();
            entityUser.Property(u => u.Email).IsRequired();
            entityUser.Property(u => u.BirthDay).IsRequired();
            entityUser.Property(u => u.Identity).IsRequired();
        }
    }
}
