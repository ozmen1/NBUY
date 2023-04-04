using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Category()
        {
            KitabeviAppDbContext context = new KitabeviAppDbContext();
            List<Category> categories = context
                .Categories
                .ToList();
            return View(categories);

        }

        public IActionResult Author()
        {
            KitabeviAppDbContext context = new KitabeviAppDbContext();
            List<Author> authors = context
                .Authors
                .ToList();
            return View(authors);
        }

        public IActionResult Book()
        {
            KitabeviAppDbContext context = new KitabeviAppDbContext();
            List<Book> books = context
                .Books
                .Include(c => c.Category)
                .Include(a => a.Author)
                .ToList();
            return View(books);
        }

    }
}