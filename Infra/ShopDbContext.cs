using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options)
            : base(options)
        {
        }
        public DbSet<OrderData> Orders { get; set; } //siia paned mitmused! - need on orderite setid
        public DbSet<OrderItemData> OrderItems { get; set; }
        public DbSet<CatalogData> Catalogs { get; set; }
        public DbSet<BrandData> Brands { get; set; }
        public DbSet<ProductData> Products { get; set; }
        public DbSet<BasketData> Baskets { get; set; }
        public DbSet<BasketItemData> BasketItems { get; set; }

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);
            InitializeTables(b);
        }

        public static void InitializeTables(ModelBuilder b)
        {
            b.Entity<BasketData>().ToTable(nameof(Baskets));
            b.Entity<BasketItemData>().ToTable(nameof(BasketItems))
                .Property(x => x.UnitPrice)
                .HasColumnType("Decimal(16,4)");
            b.Entity<ProductData>().ToTable(nameof(Products))
                .Property(x=> x.Price)
                .HasColumnType("Decimal(16,4)");
            b.Entity<BrandData>().ToTable(nameof(Brands));
            b.Entity<CatalogData>().ToTable(nameof(Catalogs));
            b.Entity<OrderItemData>().ToTable(nameof(OrderItems))
                .Property(x => x.UnitPrice)
                .HasColumnType("Decimal(16,4)");
            b.Entity<OrderData>().ToTable(nameof(Orders));





        }
    }
}
