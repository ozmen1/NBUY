using Microsoft.AspNetCore.Mvc;
using OnlineTutor.Business.Abstract;
using OnlineTutor.Entity.Concrete;
using OnlineTutor.Web.Models;
using System.Diagnostics;

namespace OnlineTutor.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICategoryService _categoryManager;

        public HomeController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _categoryManager.GetAllAsync();
            List<CategoryDto> categoryDtos = new List<CategoryDto>();
            foreach (var category in categories)
            {
                categoryDtos.Add(new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description
                });
            }
            return View(categoryDtos);
        }
    }
}