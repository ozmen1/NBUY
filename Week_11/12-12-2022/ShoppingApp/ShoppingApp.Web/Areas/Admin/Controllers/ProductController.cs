using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using System;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProductsWithCategories();
            var productListDto = products
                .Select(p => new ProductListDto
                {
                    Product = p
                }).ToList();
            return View(productListDto);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();
            var productAddDto = new ProductAddDto
            {
                Categories = categories
            };
            return View(productAddDto);
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductAddDto productAddDto)
        {
            if (ModelState.IsValid)
            {
                var url = Jobs.InitUrl(productAddDto.Name);
                var product = new Product
                {
                    Name = productAddDto.Name,
                    Price = productAddDto.Price,
                    Description = productAddDto.Description,
                    Url = url,
                    IsApproved = productAddDto.IsApproved,
                    IsHome = productAddDto.IsHome,
                    ImageUrl = Jobs.UploadImage(productAddDto.ImageFile)
                };
                await _productService.CreateProductAsync(product, productAddDto.SelectedCategoryIds);
                return RedirectToAction("Index");
            }
            var categories = await _categoryService.GetAllAsync();
            productAddDto.Categories = categories;
            return View(productAddDto);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var productsWithCategories = await _productService.GetProductWithCategories(id);
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var productUpdateDto = new ProductUpdateDto
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                //Url = Jobs.InitUrl(product.Name),
                IsApproved = product.IsApproved,
                IsHome = product.IsHome,
                //ImageUrl = product.ImageUrl
                Categories = await _categoryService.GetAllAsync();
            };
            return View(productUpdateDto);


    }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductUpdateDto productUpdateDto, int[] selectedCategoryIds)
        {
            if (ModelState.IsValid)
            {
                var product = await _productService.GetByIdAsync(productUpdateDto.id);
                if (product==null)
                {
                    return NotFound();
                }
            var url = Jobs.UploadImage(productUpdateDto.Name);
            product.Name = productUpdateDto.Name;
            product.Price = productUpdateDto.Price;
            product.Description = productUpdateDto.Description;
            product.IsApproved = productUpdateDto.IsApproved;
            product.IsHome = productUpdateDto.IsHome;
            product.ImageUrl = Jobs.UploadImage(productUpdateDto.ImageFile);
            product.Url = url;
            await _productService.UpdateProductAsync(product, selectedCategoryIds);
            return RedirectToAction("Index");
            }
        return View();
        }
    }
}
