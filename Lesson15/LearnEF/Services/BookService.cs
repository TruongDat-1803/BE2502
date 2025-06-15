using BookApp.Entities;
using BookApp.Model;
using BookApp.Model.Books;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Services
{
    public class BookService
    {
        private readonly DemoDbContext _context;
        public BookService()
        {
            _context = new DemoDbContext();
        }
        public void Create(CreateBookViewModel model)
        {
            var book = new Book
            {
                Id = new Guid(),
                Name = model.Name,
                AuthorId = model.AuthorId,
            };
            _context.Set<Book>().Add(book);
            _context.SaveChanges();
        }
        //public void Update(UpdateBookViewModel model)
        //{
        //    var book = _context.Set<Book>().FirstOrDefault(s => s.Id == model.Id);
        //    if (book == null)
        //    {
        //        throw new Exception($"The book with id {model.Id} is not found");
        //    }
        //    book.Name = model.BookName;
        //    book.AuthorId = model.Author.Id;
        //    _context.Set<Book>().Update(book);
        //    _context.SaveChanges();
        //}
        public List<BookViewModel> GetAll()
        {
            var books = _context.Books.Include(s => s.Author)
                                     .Select(b => new BookViewModel
                                     {
                                         Id = b.Id,
                                         Name = b.Name,
                                         AuthorId = b.AuthorId,
                                         AuthorName = b.Author.Name
                                     }).ToList();
            var result = books.ToList();
            return result;
        }
        public List<BookViewModel> GetAll_1()
        {
            var books = _context.Books;
            var authors = _context.Authors;
            var bookViewModels = from book in books
                         join author in authors on book.AuthorId equals author.Id
                         select new BookViewModel
                         {
                             Id = book.Id,
                             Name = book.Name,
                             AuthorId = book.AuthorId,
                             AuthorName = author.Name
                         };
            var result = bookViewModels.ToList();
            return result;
        }
        public Pagination<BookViewModel> GetPagination(BookSearchQuery query)
        {
            var page = new Pagination<BookViewModel>();
            var books = _context.Books.Include(s => s.Author)
                                     .Select(b => new BookViewModel
                                     {
                                         Id = b.Id,
                                         Name = b.Name,
                                         AuthorId = b.AuthorId,
                                         AuthorName = b.Author.Name
                                     }).ToList();
            if (!string.IsNullOrEmpty(query.Keyword))
            {
                books = books.Where(s => s.Name.Contains(query.Keyword)).ToList();
            }

            if (query.AuthorId.HasValue)
            {
                books = books.Where(s => s.AuthorId == query.AuthorId.Value).ToList();
            }

            page.Total = books.Count();
            page.Data = books.Skip(query.SkipNo).Take(query.PageSize).ToList();
            return page;
        }
        public void Delete(Guid id)
        {
            var book = _context.Set<Book>().FirstOrDefault(s => s.Id == id);
            if (book == null)
            {
                throw new Exception($"The book with id {id} is not found");
            }
            _context.Set<Book>().Remove(book);
            _context.SaveChanges();
        }
    }
}
