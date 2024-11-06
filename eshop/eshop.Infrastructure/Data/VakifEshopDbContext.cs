using eshop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Infrastructure.Data
{
    public class VakifEshopDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public VakifEshopDbContext(DbContextOptions<VakifEshopDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                                .HasMaxLength(100);

            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Category>().HasData(

                new Category() { Id = 1, Name = "Elektronik" },
                new Category() { Id = 2, Name = "Kırtasiye" },
                new Category() { Id = 3, Name = "Mobilya" }
                );


            modelBuilder.Entity<Product>().HasData(
// Elektronik (CategoryId = 1)
new Product() { Id = 1, Name = "Dell", Description = "Dell süperdir", CategoryId = 1, Price = 100, StockCount = 100 },
new Product() { Id = 2, Name = "HP Laptop", Description = "Yüksek performanslı HP laptop", CategoryId = 1, Price = 120, StockCount = 80 },
new Product() { Id = 3, Name = "Apple iPhone", Description = "Apple kalitesinde iPhone", CategoryId = 1, Price = 200, StockCount = 50 },
new Product() { Id = 4, Name = "Samsung Galaxy", Description = "Samsung Galaxy telefon", CategoryId = 1, Price = 150, StockCount = 60 },
new Product() { Id = 5, Name = "Sony Kulaklık", Description = "Sony kaliteli kulaklık", CategoryId = 1, Price = 60, StockCount = 150 },
new Product() { Id = 6, Name = "Canon Kamera", Description = "Canon profesyonel kamera", CategoryId = 1, Price = 300, StockCount = 40 },
new Product() { Id = 7, Name = "LG Televizyon", Description = "LG geniş ekran TV", CategoryId = 1, Price = 500, StockCount = 25 },

// Kırtasiye (CategoryId = 2)
new Product() { Id = 8, Name = "Pilot Kalem", Description = "Rahat yazım için Pilot kalem", CategoryId = 2, Price = 5, StockCount = 500 },
new Product() { Id = 9, Name = "Defter", Description = "100 yapraklı kaliteli defter", CategoryId = 2, Price = 10, StockCount = 300 },
new Product() { Id = 10, Name = "Masaüstü Organizer", Description = "Ofis için organizer", CategoryId = 2, Price = 20, StockCount = 120 },
new Product() { Id = 11, Name = "Dosya", Description = "Belgeler için dosya", CategoryId = 2, Price = 2, StockCount = 400 },
new Product() { Id = 12, Name = "Cetvel Seti", Description = "Matematik için cetvel seti", CategoryId = 2, Price = 8, StockCount = 200 },
new Product() { Id = 13, Name = "Tükenmez Kalem", Description = "Mavi tükenmez kalem", CategoryId = 2, Price = 3, StockCount = 600 },
new Product() { Id = 14, Name = "Silgi", Description = "Yumuşak yapıda silgi", CategoryId = 2, Price = 1, StockCount = 1000 },

// Mobilya (CategoryId = 3)
new Product() { Id = 15, Name = "Ofis Sandalyesi", Description = "Rahat ofis sandalyesi", CategoryId = 3, Price = 150, StockCount = 70 },
new Product() { Id = 16, Name = "Çalışma Masası", Description = "Modern tasarımlı çalışma masası", CategoryId = 3, Price = 200, StockCount = 50 },
new Product() { Id = 17, Name = "Kitaplık", Description = "Geniş kitaplık", CategoryId = 3, Price = 120, StockCount = 40 },
new Product() { Id = 18, Name = "L Koltuk", Description = "Konforlu L koltuk", CategoryId = 3, Price = 600, StockCount = 20 },
new Product() { Id = 19, Name = "Sehpa", Description = "Şık sehpa", CategoryId = 3, Price = 70, StockCount = 100 },
new Product() { Id = 20, Name = "Gardırop", Description = "3 kapılı geniş gardırop", CategoryId = 3, Price = 300, StockCount = 30 }

             );
        }
    }
}
