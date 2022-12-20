using ShoppingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Entity.Concrete
{
    public class Product : IEntityBase
    {
        public int Id { get; set ; }
        public string Name { get; set; }
        public decimal? Price { get; set; } //?=ilgili proporty'i nullable yapar... boş bırakıldığında 0 atanmasını engeller.
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsHome { get; set; } //anasayfa ürünü mü
        public bool IsApproved { get; set; } //onaylı mı
        public DateTime DateAdded { get; set; } //eklenme tarihi
        public List<ProductCategory> ProductCategories { get; set; } //bir product'ın birden fazla kategoride olması için

    }
}
