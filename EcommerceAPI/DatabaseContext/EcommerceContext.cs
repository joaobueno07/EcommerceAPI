using System;
using System.Collections.Generic;
using EcommerceAPI.ConfigDb;
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

            modelBuilder.ApplyConfiguration(new ConfigureSale());
            modelBuilder.ApplyConfiguration(new ConfigureProduct());
        }
    }
}
