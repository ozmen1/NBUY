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
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.CommentText)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(t => t.Point)
                .IsRequired();

            builder.ToTable("Comments");

            builder.HasData(
                    new Comment()
                    {
                        Id = 1,
                        TeacherId = 1,
                        StudentId = 2,
                        //Title = "Çok iyii", 
                        CommentText = "Mükemmel bir eğitimci.",
                        Url = "comment-1"
                    },
                    new Comment()
                    {
                        Id = 2,
                        TeacherId = 2,
                        StudentId = 1,
                        //Title = "Çok iyii", 
                        CommentText = "Harika bir eğitimci.",
                        Url = "comment-2"
                    }

                );
        }

    }
}
