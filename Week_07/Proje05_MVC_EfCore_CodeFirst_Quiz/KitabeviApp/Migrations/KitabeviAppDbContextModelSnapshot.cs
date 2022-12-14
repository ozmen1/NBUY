// <auto-generated />
using KitabeviApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KitabeviApp.Migrations
{
    [DbContext(typeof(KitabeviAppDbContext))]
    partial class KitabeviAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.11");

            modelBuilder.Entity("KitabeviApp.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<char>("Cinsiyet")
                        .HasColumnType("TEXT");

                    b.Property<int>("DogumYili")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Matt Heig",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Feyyaz Yiğit",
                            Cinsiyet = 'E',
                            DogumYili = 1990
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Gizem Doğan",
                            Cinsiyet = 'K',
                            DogumYili = 1960
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Jack London",
                            Cinsiyet = 'E',
                            DogumYili = 1930
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Margaret Atwood",
                            Cinsiyet = 'K',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 6,
                            Ad = "Cem Akaş",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 7,
                            Ad = "Zafer Demirkol",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 8,
                            Ad = "İlber Ortaylı",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 9,
                            Ad = "Seda Yiğit",
                            Cinsiyet = 'K',
                            DogumYili = 1980
                        },
                        new
                        {
                            Id = 10,
                            Ad = "George Orwell",
                            Cinsiyet = 'E',
                            DogumYili = 1980
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<int>("AuthorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BasimYili")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SayfaSayisi")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "İnsanlar",
                            AuthorId = 1,
                            BasimYili = 2021,
                            CategoryId = 2,
                            SayfaSayisi = 330
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Zamanı Durdurmanın Yolları",
                            AuthorId = 1,
                            BasimYili = 2021,
                            CategoryId = 1,
                            SayfaSayisi = 370
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Demir Ökçe",
                            AuthorId = 4,
                            BasimYili = 2017,
                            CategoryId = 2,
                            SayfaSayisi = 400
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Huzursuzluk",
                            AuthorId = 9,
                            BasimYili = 2018,
                            CategoryId = 2,
                            SayfaSayisi = 330
                        },
                        new
                        {
                            Id = 5,
                            Ad = "Serenad",
                            AuthorId = 9,
                            BasimYili = 2020,
                            CategoryId = 2,
                            SayfaSayisi = 300
                        },
                        new
                        {
                            Id = 6,
                            Ad = "19",
                            AuthorId = 6,
                            BasimYili = 2016,
                            CategoryId = 2,
                            SayfaSayisi = 380
                        },
                        new
                        {
                            Id = 7,
                            Ad = "C# Programlama Dili",
                            AuthorId = 7,
                            BasimYili = 2011,
                            CategoryId = 3,
                            SayfaSayisi = 730
                        },
                        new
                        {
                            Id = 8,
                            Ad = "React Uygulama Geliştirme",
                            AuthorId = 3,
                            BasimYili = 2021,
                            CategoryId = 3,
                            SayfaSayisi = 530
                        },
                        new
                        {
                            Id = 9,
                            Ad = "İnsan Ömrünü Neyle Geçirmeli?",
                            AuthorId = 8,
                            BasimYili = 2021,
                            CategoryId = 2,
                            SayfaSayisi = 330
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .HasColumnType("TEXT");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Çocuk Kitapları",
                            Ad = "Çocuk"
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "Roman, Hikaye, Şiir Kitapları",
                            Ad = "Edebiyat"
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "Bilgisayar Kitapları",
                            Ad = "Bilgisayar"
                        },
                        new
                        {
                            Id = 4,
                            Aciklama = "Akademik Kitaplar",
                            Ad = "Akademik"
                        });
                });

            modelBuilder.Entity("KitabeviApp.Models.Book", b =>
                {
                    b.HasOne("KitabeviApp.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KitabeviApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
