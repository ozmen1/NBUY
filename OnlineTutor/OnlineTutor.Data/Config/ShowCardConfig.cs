using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTutor.Data.Config
{
    public class ShowCardConfig : IEntityTypeConfiguration<ShowCard>
    {
        public void Configure(EntityTypeBuilder<ShowCard> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .IsRequired();

            builder.Property(t => t.Description)
                .IsRequired();

            builder.Property(t => t.Price)
                .IsRequired();

            builder.ToTable("ShowCards");

            builder.HasData(
                  new ShowCard()
                  {
                      Id = 1,
                      TeacherId = 1,
                      Title = "Online Matematik Dersi",
                      Description = "Lise, Üniversite matematik dersleri verilir.",
                      SubjectId = 1,
                      Url = "ozel-ders-1",
                      Price = 100,
                  },
                  new ShowCard()
                  {
                      Id = 2,
                      TeacherId = 2,
                      Title = "Online İngilizce Dersi",
                      Description = "İngilizce anadilli hocadan ingilizce dersleri.",
                      SubjectId = 3,
                      Url = "ozel-ders-ing",
                      Price = 100,
                  }
                  );
        }
    }
}
