using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Web.Models.Dtos
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; } //?=soru işaretinin anlamı nullable olabilir demek
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public List<Category> Categories { get; set; }
    }
}
