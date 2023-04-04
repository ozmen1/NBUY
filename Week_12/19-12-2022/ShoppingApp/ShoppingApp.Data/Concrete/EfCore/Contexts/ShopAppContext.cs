using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Config;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Contexts
{
    public class ShopAppContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        public ShopAppContext(DbContextOptions<ShopAppContext>options):base(options) //nesne program.cs'de yaratıldı.
        {

        }

        //override kısayol : override onconfiguring tab
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) ////burayı sildik. program.cs'de appsettings.json dosyasında yazılıp program.cs'de yarattık......
        //{
        //    optionsBuilder.UseSqlite("Data Source=ShoppingApp.db");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configurationlarımızı uygulayacağız.
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new ProductCategoryConfig());

        }
    }
}
