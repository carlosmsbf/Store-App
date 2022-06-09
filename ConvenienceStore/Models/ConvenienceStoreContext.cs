using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConvenienceStore.Models
{
    public class ConvenienceStoreContext: DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<Report> Report { get; set; }


        public ConvenienceStoreContext(DbContextOptions<ConvenienceStoreContext> options) : base(options) {        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cellphone", Description = "Cellphones" },
                new Category { Id = 2, Name = "TV", Description = "Television" },
                new Category { Id = 3, Name = "Laptop", Description = "Portatil Computer" },
                new Category { Id = 4, Name = "Gaming Console", Description = "PlayStation, Xbox or Wii console" },
                new Category { Id = 5, Name = "Tablet", Description = "Ipad, Galaxy note and others." },
                new Category { Id = 6, Name = "Home Appliances", Description = "Echo Dot, Google Cast, Alexia Fire, and others." }
           );

            modelBuilder.Entity<Brand>().HasData(
    new Brand { Id = 1, Name = "LG" },
    new Brand { Id = 2, Name = "Samsung" },
    new Brand { Id = 3, Name = "Sony" },
    new Brand { Id = 4, Name = "Apple" },
    new Brand { Id = 5, Name = "Xiaomi" },
    new Brand { Id = 6, Name = "MSI" },
    new Brand { Id = 7, Name = "Dell" },
    new Brand { Id = 8, Name = "Microsoft" },
    new Brand { Id = 9, Name = "Insignia" },
    new Brand { Id = 10, Name = "Hamilton" },
    new Brand { Id = 11, Name = "Nespresso" }
);

            modelBuilder.Entity<Product>().HasData(
new Product { Id = 1, Name = "OLED TV", BrandId = 1, CategoryId=2, Description= "55 inch 4K OLED Smart TV" },
new Product { Id = 2, Name = "OLED TV", BrandId = 2, CategoryId = 2, Description = "75 inch 8K QLED Smart TV" },
new Product { Id = 3, Name = "Smart TV", BrandId = 2, CategoryId = 2, Description = "65 inch 4K Smart TV" },
new Product { Id = 4, Name = "X80J TV", BrandId = 3, CategoryId = 2, Description = "75 inch 4K HDR LED Smart TV" },
new Product { Id = 5, Name = "Galaxy S22", BrandId = 2, CategoryId = 1, Description = "6.1 inch display, 1080x2340 pixels, 50MP Camera, 8GB RAM, 250GB, Android 12" },
new Product { Id = 6, Name = "Samsung Galaxy S21", BrandId = 2, CategoryId = 1, Description = "6.4 inch display, 1080x2400 pixels, 12MP Camera, 8GB RAM, 500GB, Android 12" },
 new Product { Id = 7, Name = "Nespresso Vertuo Coffee", Description = "Nespresso Vertuo Coffee & Espresso Machine by DeLonghi w/ Aeroccino Milk Frother, Black", BrandId = 11, CategoryId = 6 },
  new Product { Id = 8, Name = "Hamilton Beach Toaster", Description = "2-Slice toaster in chrome, high-lift boost toast function, Extra-wide slots", BrandId = 10, CategoryId = 6 },
  new Product { Id = 9, Name = "Insignia Air Fryer", Description = "4.8L capacity, Stainless Steel, Hot air, 60 minutes timer", BrandId = 9, CategoryId = 6 },
  new Product { Id = 10, Name = "LG Microwave OTR", Description = "1.7cu, Over-the-Range Microwave Oven with EasyClean", BrandId = 1, CategoryId = 6 },
new Product { Id = 11, Name = "LG Microwave NeoChef", Description = "1.5cu, Countertop Microwave with Smart Inverter and EasyClean", BrandId = 1, CategoryId = 6 },
                new Product { Id = 12, Name = "Samsung Galaxy Tab A7", Description = "8.7 inch display, 32GB, Android 12", BrandId = 2, CategoryId = 5 },
       new Product { Id = 16, Name = "Apple Ipad", Description = "Ipad 10.2 display, 6GB RAM, 500GB, 12MP Camera, iOS 15", BrandId = 4, CategoryId = 5 }
);



        }

        }
}
