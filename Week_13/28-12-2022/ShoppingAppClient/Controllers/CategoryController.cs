using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShoppingAppClient.Models;

namespace ShoppingAppClient.Controllers
{
    public class CategoryController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var kategoriler = new List<CategoryViewModel>();
            using (var httpClient = new HttpClient()) //using=işi bittikten sonra bellekten yok olsun
            {
                using (var response = await httpClient.GetAsync("http://localhost:5200/api/categories/"))
                //using (var response = await httpClient.GetAsync("http://shoppingapp.somee.com/api/categories"))
                {
                    //json formatını deserialize edip productviewmodel'e çevirelim.
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    kategoriler = JsonConvert.DeserializeObject<List<CategoryViewModel>>(apiResponse);
                }
            }
            return View(kategoriler);
        }
    }
}
