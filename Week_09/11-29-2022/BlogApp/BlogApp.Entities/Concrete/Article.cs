using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
    public class Article : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; } //resmin url bilgisini tutacak
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public int CategoryId { get; set; } //Id sözcüğünü entityframework özel olarak algılıyor. isimlendirmeye dikkat!
        public Category Category { get; set; } //Navigation Property
        public int UserId { get; set; }
        public User User { get; set; } //Navigation Property
        public ICollection<Comment> Comments { get; set; } //Navigation Property
        public ICollection<Article> Articles { get; set; } //Navigation Property

    }
}
