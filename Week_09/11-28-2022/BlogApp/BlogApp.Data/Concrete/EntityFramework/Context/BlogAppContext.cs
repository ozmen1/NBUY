using BlogApp.Data.Concrete.EntityFramework.Mappings;
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Context
{
    public class BlogAppContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //override ederek metodu çağırdık
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-OFVK2FD;Database=BlogAppDb;Integrated Security=true;TrustServerCertificate=true");
            #region TrustedServerCertificate
            //EntityFrameworkCore 7 ile SqlServer veri tabanına bağlantı ile ilgili önemli bir değişiklik olmuştur. Bu da güvenlik amacıyla doğrulanmış sertifika gereksinimidir. Bunun ifade eden TrustServerCertificate özelliği böyle bir sertifika yoksa true'ya çekilmedilir, çünkü default olarak false'dur. False iken maalesef veritabanına bağlansa bile kullanıma izin vermez.
            #endregion

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new UserMap());

        }
    }
}
