using ERP502.Models;
using ERP502.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ERP502.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailService _emailService;

        public HomeController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _emailService.Send("mesut@wissen.com", "Test mesajı", "Konu");
            return View();
        }

        public IActionResult Privacy()
        {
            var service = _emailService as EmailService;
            service.SenderMail = "noreply@bilmemne.com";
            _emailService.Send("mesut@wissen.com", "Test mesajı", "Konu");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}