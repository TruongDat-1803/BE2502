using DemoWeb.Models;
using DemoWeb.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Service _service1;
        private readonly Service _service2;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _service1 = new Service();
            _service2 = new Service();
        }

        public IActionResult Index()
        {
            ViewBag.Id1 = _service1.Id;
            ViewBag.Id2 = _service2.Id;
            var httpContext = HttpContext;
            return View();
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
