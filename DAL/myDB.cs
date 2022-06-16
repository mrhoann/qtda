using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class myDB : DbContext
    {
        public myDB()
            : base("name=myDB")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ElectroluxProductDe> ElectroluxProductDes { get; set; }
        public virtual DbSet<FashionProductDe> FashionProductDes { get; set; }
        public virtual DbSet<ImageProductDe> ImageProductDes { get; set; }
        public virtual DbSet<LaptopProductDe> LaptopProductDes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductSales)
                .WithOptional(e => e.Product)
                .HasForeignKey(e => e.CategoryID);
        }
    }
}
