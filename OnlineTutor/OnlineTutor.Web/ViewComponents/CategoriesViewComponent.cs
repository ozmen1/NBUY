using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;

namespace OnlineTutor.Web.ViewComponents
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
            var categories = await _categoryManager.GetAllAsync();
            return View(categories);
        }
    }
}
