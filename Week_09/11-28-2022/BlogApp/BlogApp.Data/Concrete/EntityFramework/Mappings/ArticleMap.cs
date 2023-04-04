﻿using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{

    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            #region Aciklama1
            //Burada EfCore tarafından default convention yöntemi ile kendiliğinden gerçekleşen banzı ayarları elle yapıyor olacağız. Bu daha profesyonel, sürdürülebilir, genişletilebilir uygulamalar yapmak için tercih edilen bir yoldur.
            #endregion
            builder.HasKey(a => a.Id); //PrimaryKey
            builder.Property(a => a.Id).ValueGeneratedOnAdd(); //Identity eklendikçe birer birer artış

            builder.Property(a => a.Title).IsRequired(); //zorunlu (varsayılanı true yani zorunlu)
            builder.Property(a => a.Title).HasMaxLength(100); //maksimum 100 karakter

            builder.Property(a => a.Content).IsRequired();
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");

            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);

            builder.Property(a => a.Date).IsRequired();
            
            builder.Property(a => a.SeoAuthor).IsRequired();
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);

            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(150);

            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);

            builder.Property(a => a.ViewsCount).IsRequired();

            builder.Property(a => a.CommentCount).IsRequired();

            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(50);

            builder.Property(a => a.ModifiedByName).IsRequired();
            builder.Property(a => a.ModifiedByName).HasMaxLength(50);

            builder.Property(a => a.CreatedDate).IsRequired();

            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.Property(a => a.IsDeleted).IsRequired();

            builder.Property(a => a.IsActive).IsRequired();

            builder.Property(a => a.Note).HasMaxLength(500);

            builder.HasOne(c => c.Category)
                .WithMany(a => a.Articles)
                .HasForeignKey(a => a.CategoryId);

            builder.HasOne(u => u.User)
                .WithMany(a => a.Articles)
                .HasForeignKey(a => a.UserId);

            builder.ToTable("Articles");

            //İlk Article verilerinin eklenmesi

            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId= 1,
                    UserId= 1,
                    Title="C# 11.0 Yenilikleri",
                    Content= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    Thumbnail="default.jpg",
                    SeoDescription= "C# 11.0 Yenilikleri",
                    SeoTags="C#, C# 11.0, DotNet 6, DotNet 7, DotNet Core",
                    SeoAuthor="Deniz Gezen",
                    ViewsCount=116,
                    CommentCount=1,
                    Date=DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 11.0 Yenilikleri"
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    UserId = 1,
                    Title = "Modern Javascript",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "Modern Javascript",
                    SeoTags = "Javascript, ECMA Script 6, map, filteri reduce, arrow function",
                    SeoAuthor = "Deniz Gezen",
                    ViewsCount = 193,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "Modern Javascript"
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    UserId = 2,
                    Title = "React Component Yapısı",
                    Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "React Component Yapısı",
                    SeoTags = "React, React JS, Component, state, class component, function component",
                    SeoAuthor = "Yusuf Onan",
                    ViewsCount = 225,
                    CommentCount = 1,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreated",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "React Component Yapısı"
                });
        }
    }
}
