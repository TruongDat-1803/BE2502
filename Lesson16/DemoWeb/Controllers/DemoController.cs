using DemoWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoWeb.Controllers
{
    public class DemoController : Controller
    {
        private readonly IServiceA _service1;
        private readonly IServiceA _service2;

        public DemoController(IServiceA service1, IServiceA service2)
        {
            _service1 = service1;
            _service2 = service2;
        }
        public IActionResult Index()
        {
            ViewBag.Id1 = _service1.Id;
            ViewBag.Id2 = _service2.Id;
            return View();
        }
        public IActionResult TestPage()
        {
            return View();
        }
    }
}
