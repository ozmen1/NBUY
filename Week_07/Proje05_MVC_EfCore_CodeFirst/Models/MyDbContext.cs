using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Proje05_MVC_EfCore_CodeFirst.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=First.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category(){Id=1, Name="Phone", Desc="Phones"},
                    new Category(){Id=2, Name="Computer", Desc="Computers"},
                    new Category(){Id=3, Name="Elecronic", Desc="Electronics"}
                );

                modelBuilder.Entity<Product>()
                    .HasData(
                        new Product(){Id=1, Name="Iphone13", Desc="Güzel bir telefon", Price=19000, CategoryId=1},
                        new Product(){Id=2, Name="DellXside", Desc="Güzel bir pc", Price=15000, CategoryId=2},
                        new Product(){Id=3, Name="SamsungA71", Desc="Kamerası çok güzeş", Price=17000, CategoryId=1},
                        new Product(){Id=4, Name="PiranhaX13", Desc="Her yerde Ses", Price=10000, CategoryId=3}
                    );

                modelBuilder.Entity<City>()
                    .HasData(
                        new City(){Id=34, Name="İstanbul"},
                        new City(){Id=35, Name="İzmir"},
                        new City(){Id=41, Name="Kocaeli"}
                    );
        }
    }
}