using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PORTAL2023.Models;

namespace PORTAL2023.Controllers
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
        public IActionResult Primeirospassos()
        {
            return View();
        }
        public IActionResult Meubolso()
        {
            return View();
        }
        public ActionResult OpenExternalLink(int idLink)
        {
            return Redirect("https://rendafixa.github.io");
        }

        public IActionResult Privacy()
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
