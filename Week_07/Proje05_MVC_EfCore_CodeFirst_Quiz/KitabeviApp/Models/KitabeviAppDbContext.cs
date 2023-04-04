using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
namespace KitabeviApp.Models
{
    public class KitabeviAppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=deneme.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                 .HasData(
                     new Category() { Id = 1, Ad = "Çocuk", Aciklama = "Çocuk Kitapları" },
                     new Category() { Id = 2, Ad = "Edebiyat", Aciklama = "Roman, Hikaye, Şiir Kitapları" },
                     new Category() { Id = 3, Ad = "Bilgisayar", Aciklama = "Bilgisayar Kitapları" },
                     new Category() { Id = 4, Ad = "Akademik", Aciklama = "Akademik Kitaplar" }
                 );

            modelBuilder.Entity<Author>()
                .HasData(
                    new Author() { Id = 1, Ad = "Matt Heig", DogumYili = 1980, Cinsiyet = 'E' },
                    new Author() { Id = 2, Ad = "Feyyaz Yiğit", DogumYili = 1990, Cinsiyet = 'E' },
                    new Author() { Id = 3, Ad = "Gizem Doğan", DogumYili = 1960, Cinsiyet = 'K' },
                    new Author() { Id = 4, Ad = "Jack London", DogumYili = 1930, Cinsiyet = 'E' },
                    new Author() { Id = 5, Ad = "Margaret Atwood", DogumYili = 1980, Cinsiyet = 'K' },
                    new Author() { Id = 6, Ad = "Cem Akaş", DogumYili = 1980, Cinsiyet = 'E' },
                    new Author() { Id = 7, Ad = "Zafer Demirkol", DogumYili = 1980, Cinsiyet = 'E' },
                    new Author() { Id = 8, Ad = "İlber Ortaylı", DogumYili = 1980, Cinsiyet = 'E' },
                    new Author() { Id = 9, Ad = "Seda Yiğit", DogumYili = 1980, Cinsiyet = 'K' },
                    new Author() { Id = 10, Ad = "George Orwell", DogumYili = 1980, Cinsiyet = 'E' }
                );
            modelBuilder.Entity<Book>()
                .HasData(
                    new Book() { Id = 1, Ad = "İnsanlar", BasimYili = 2021, SayfaSayisi = 330, CategoryId = 2, AuthorId = 1 },
                    new Book() { Id = 2, Ad = "Zamanı Durdurmanın Yolları", BasimYili = 2021, SayfaSayisi = 370, CategoryId = 1, AuthorId = 1 },
                    new Book() { Id = 3, Ad = "Demir Ökçe", BasimYili = 2017, SayfaSayisi = 400, CategoryId = 2, AuthorId = 4 },
                    new Book() { Id = 4, Ad = "Huzursuzluk", BasimYili = 2018, SayfaSayisi = 330, CategoryId = 2, AuthorId = 9 },
                    new Book() { Id = 5, Ad = "Serenad", BasimYili = 2020, SayfaSayisi = 300, CategoryId = 2, AuthorId = 9 },
                    new Book() { Id = 6, Ad = "19", BasimYili = 2016, SayfaSayisi = 380, CategoryId = 2, AuthorId = 6 },
                    new Book() { Id = 7, Ad = "C# Programlama Dili", BasimYili = 2011, SayfaSayisi = 730, CategoryId = 3, AuthorId = 7 },
                    new Book() { Id = 8, Ad = "React Uygulama Geliştirme", BasimYili = 2021, SayfaSayisi = 530, CategoryId = 3, AuthorId = 3 },
                    new Book() { Id = 9, Ad = "İnsan Ömrünü Neyle Geçirmeli?", BasimYili = 2021, SayfaSayisi = 330, CategoryId = 2, AuthorId = 8 }
                );
        }

    }
}

