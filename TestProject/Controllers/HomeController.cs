using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var name = "Elvin";
            var name2 = "Elvin";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}