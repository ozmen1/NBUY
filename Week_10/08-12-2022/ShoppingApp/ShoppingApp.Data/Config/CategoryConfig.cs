using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //bu alanlar veritabanı ile ilgili ayarlardır
            builder.HasKey(c => c.Id); //category'nin primary key'i programa tanıtıldı
            builder.Property(c => c.Id).ValueGeneratedOnAdd(); //yeni bir ekleme yapıldığında oluşturacaksın
            builder.Property(c => c.Name)
                .IsRequired() //zorunlu alan olsun
                .HasMaxLength(50);
            builder.Property(c => c.Description)
                .IsRequired() //zorunlu alan olsun
                .HasMaxLength(500);
            builder.Property(c => c.Url)
                .IsRequired() //zorunlu alan olsun
                .HasMaxLength(250);
            builder.ToTable("Categories"); //veritabanında oluşacağı isim
            //örnek bilgilerin oluşturulması
            builder.HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Telefon",
                        Description = "Telefonlar bu kategoride bulunmaktadır.",
                        Url = "telefon"
                    },

                    new Category
                    {
                        Id = 2,
                        Name = "Elektronik",
                        Description = "Elektronikler bu kategoride bulunmaktadır.",
                        Url = "elektronik"
                    },

                    new Category
                    {
                        Id = 3,
                        Name = "Bilgisayar",
                        Description = "Bilgisayarlar bu kategoride bulunmaktadır.",
                        Url = "bilgisayar"
                    },

                    new Category
                    {
                        Id = 4,
                        Name = "Beyaz Eşya",
                        Description = "Beyaz Eşyalar bu kategoride bulunmaktadır.",
                        Url = "beyaz-esya"
                    }
                );
        }
    }
}
