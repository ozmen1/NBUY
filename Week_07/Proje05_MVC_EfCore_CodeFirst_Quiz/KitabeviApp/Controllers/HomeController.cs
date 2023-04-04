using System.Diagnostics;
using KitabeviApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace KitabeviApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}