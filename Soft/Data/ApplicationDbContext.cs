using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Soft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OrderData> Orders { get; set; } //siia paned mitmused! - need on orderite setid
        public DbSet<OrderItemData> OrderItems { get; set; }
        public DbSet<CatalogTypeData> CatalogTypes { get; set; }
        public DbSet<CatalogBrandData> CatalogBrands { get; set; }
        public DbSet<CatalogData> Catalogs { get; set; }
        public DbSet<BasketData> Baskets { get; set; }
        public DbSet<BasketItemData> BasketItems { get; set; }






    }
}
