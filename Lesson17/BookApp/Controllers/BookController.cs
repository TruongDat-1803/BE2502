using BookApp.Models.Books;
using BookApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        public BookController(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _bookService.GetAll();
            return View(books);
        }
        public async Task<IActionResult> Update(Guid id)
        {
            var book = await _bookService.GetById(id);
            var authors = await _authorService.GetAll();
            ViewBag.Authors = authors;
            var model = new UpdateBookViewModel()
            {
                Id = book.Id,
                Name = book.Name,
                AuthorId = book.AuthorId
            };
            return View(model);
        }

        public async Task<IActionResult> Create()
        {
            var authors = await _authorService.GetAll();
            
            return View(authors);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateBookViewModel model)
        {
            await _bookService.Create(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateBookViewModel model)
        {
            await _bookService.Update(model);
            return RedirectToAction("Index");
        }
    }
}
