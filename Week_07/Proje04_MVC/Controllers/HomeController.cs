using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje04_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        string ad = "Kerem";
        ViewBag.KisiAd=ad;
        string dil = "Tr";
        string selamlama;
        if (dil == "Tr")
        {
            selamlama = "Hoş geldiniz";
        }
        else if (dil == "En")
        {
            selamlama = "Welcome";
        }
        else
        {
            selamlama = "";
        }
        ViewBag.Selam=selamlama;

        return View();
    }
}
