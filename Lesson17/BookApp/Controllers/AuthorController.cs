using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
