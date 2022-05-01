using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Mar

namespace MarketData
{
    public class meTechOrderAppContext : DbContext
    {
        public meTechOrderAppContext(DbContextOptions<meTechOrderAppContext> options)
            : base(options)
        {

        }
        public DbSet<Product> ApiUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}