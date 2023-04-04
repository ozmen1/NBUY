using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;

namespace ShoppingApp.Web.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (RouteData.Values["categoryurl"] != null)
            {
                ViewBag.SelectedCategory = RouteData.Values["categoryurl"]; //RouteData=link/kategorismi oluyor...program.cs'deki category pattern'ını kullan...eski kullanımda category yazıyordu id ile değiştirdik....
            }
            var categories = await _categoryManager.GetAllAsync();
            return View(categories);
        }
    }
}
