﻿using AngularETicaret.Core.DBModels;
using Microsoft.EntityFrameworkCore;

namespace AngularETicaret.Infrastructure.DataContext
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
