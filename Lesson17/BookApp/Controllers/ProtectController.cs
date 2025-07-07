using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    [Authorize(Roles = Constants.Role.Admin)]
    public class ProtectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
