using System;
using System.Collections.Generic;
using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceAPI.DatabaseContext
{
    public class EcommerceContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Sale> Sales { get; set; }

        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigureSale(modelBuilder.Entity<Sale>());
            ConfigureUser(modelBuilder.Entity<User>());
            ConfigureProduct(modelBuilder.Entity<Product>());
        }

        private void ConfigureProduct(EntityTypeBuilder<Product> entityProduct)
        {
            entityProduct.HasKey(p => p.ProductId);

            entityProduct.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(150);

            entityProduct.Property(p => p.Price)
                .IsRequired();

            entityProduct.Property(p => p.Category)
                .HasMaxLength(100);

            entityProduct.Property(p => p.Quantity)
                .IsRequired();
            
        }

        private void ConfigureUser(EntityTypeBuilder<User> entityUser)
        {
            entityUser.HasKey(u => u.UserId);

            entityUser.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(150);

            entityUser.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(100);

            entityUser.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(100);

            entityUser.Property(u => u.BirthDay)
                .IsRequired();

            entityUser.Property(u => u.Identity)
                .HasMaxLength(30);
        }

        private void ConfigureSale(EntityTypeBuilder<Sale> entitySale)
        {
            entitySale.HasKey(s => s.SaleId);
            entitySale.Property(s => s.TotalPrice).IsRequired();

            entitySale.HasOne(s => s.User)
                .WithMany(u => u.UserSales)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            entitySale.HasOne(s => s.Product)
                .WithMany(p => p.Sales)
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
