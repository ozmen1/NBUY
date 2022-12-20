using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class ProductListDto
    {
        //public List<Product> Products { get; set; } //sildik
        public Product Product { get; set; }
        //buraya kullanacağımız propertyleri yapmamız lazım normalde ama şuanda hız kazanmak için Product'ın bütün alanlarını getirmesini istedik.

    }
}
