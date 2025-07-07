using BookApp.Models.Authors;
using BookApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _authorService.GetAll_AuthorAndBook();
            return View(authors); 
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateAuthorViewModel model)
        {
            await _authorService.Create(model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(Guid id)
        {
            var author = await _authorService.GetById(id);
            var model = new UpdateAuthorViewModel()
            {
                Id = author.Id,
                Name = author.Name,

            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateAuthorViewModel model)
        {
            await _authorService.Update(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _authorService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
