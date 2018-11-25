
using Domains;
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

        public virtual DbSet<ApplicationParam> ApplicationParams { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductModel> ProductModels { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductView> ProductView { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Visitor> Visistors { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            base.OnModelCreating(builder);
        }
    }
}