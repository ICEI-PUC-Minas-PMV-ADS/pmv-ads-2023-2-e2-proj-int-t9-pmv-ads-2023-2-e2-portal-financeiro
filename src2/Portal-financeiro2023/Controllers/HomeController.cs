using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portal_financeiro2023.Models;

namespace Portal_financeiro2023.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sobre()
        {
            return View();
        }
        public IActionResult Passos()
        {
            return View();
        }
        public IActionResult Ferramentas()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

    }

}
