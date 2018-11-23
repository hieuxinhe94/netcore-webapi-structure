using Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace Dal
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(new Product { Id = 1, CategoryId = 1, DateCreated = DateTime.Now });
            builder.Entity<Product>().HasData(new Product { Id = 2, CategoryId = 2, DateCreated = DateTime.Now });

            base.OnModelCreating(builder);
        }
    }
}