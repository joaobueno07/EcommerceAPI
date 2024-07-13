using System;
using System.Collections.Generic;
using EcommerceAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.DatabaseContext
{
    public class EcommerceContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }
    }
}
