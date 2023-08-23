using System;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/1.jpeg", ProductName = "Computer", Price = 17000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/2.jpeg", ProductName = "Keyboard", Price = 1000, ShowCase = false },
                new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/3.jpeg", ProductName = "Mouse", Price = 500, ShowCase = false },
                new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/4.jpeg", ProductName = "Monitor", Price = 7000, ShowCase = false },
                new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/5.jpeg", ProductName = "Deck", Price = 1500, ShowCase = false },
                new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/6.jpeg", ProductName = "History", Price = 1500, ShowCase = false },
                new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/7.jpeg", ProductName = "Hamlet", Price = 1500, ShowCase = false },
                new Product() { ProductId = 8, CategoryId = 1, ImageUrl = "/images/8.jpeg", ProductName = "Charge", Price = 700, ShowCase = true },
                new Product() { ProductId = 9, CategoryId = 1, ImageUrl = "/images/9.jpeg", ProductName = "MacBook", Price = 20000, ShowCase = true },
                new Product() { ProductId = 10, CategoryId = 1, ImageUrl = "/images/10.jpeg", ProductName = "IWatch", Price = 5000, ShowCase = true }); 
        }
    } 
}

 