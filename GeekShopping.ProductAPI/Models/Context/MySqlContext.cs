using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Models.Context
{
   public class MySqlContext : DbContext
   {
      public MySqlContext()
      {

      }

      public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
      {

      }

      public DbSet<Product> Products { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 3,
            Name = "Iphone 7",
            Price = new decimal(1000),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 4,
            Name = "Iphone 8",
            Price = new decimal(1200),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 5,
            Name = "Iphone X",
            Price = new decimal(1400),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 6,
            Name = "Iphone XR",
            Price = new decimal(1500),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 7,
            Name = "Iphone XS",
            Price = new decimal(1600),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 8,
            Name = "Iphone XS Max",
            Price = new decimal(1800),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 9,
            Name = "Iphone 11 Mini",
            Price = new decimal(2000),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 10,
            Name = "Iphone 11",
            Price = new decimal(2200),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 11,
            Name = "Iphone 11 Pro",
            Price = new decimal(2400),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 12,
            Name = "Iphone 12 Mini",
            Price = new decimal(2500),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 13,
            Name = "Iphone 12",
            Price = new decimal(2600),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 14,
            Name = "Iphone 12 Pro",
            Price = new decimal(2800),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 15,
            Name = "Iphone 13 Mini",
            Price = new decimal(3000),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 16,
            Name = "Iphone 11",
            Price = new decimal(3200),
            Description = "",
            Category = "",
            ImageURL = ""
         });

         modelBuilder.Entity<Product>().HasData(new Product
         {
            Id = 17,
            Name = "Iphone 13 Pro",
            Price = new decimal(3400),
            Description = "",
            Category = "",
            ImageURL = ""
         });
      }
   }
}