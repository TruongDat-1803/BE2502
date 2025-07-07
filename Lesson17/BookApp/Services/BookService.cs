using BookApp.Entities;
using BookApp.Models;
using BookApp.Models.Books;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Services
{
    public class BookService : IBookService
    {
        private readonly DemoDbContext _context;
        public BookService(DemoDbContext context)
        {
            _context = context;
        }
        public async Task Create(CreateBookViewModel model)
        {
            var book = new Book
            {
                Id = new Guid(),
                Name = model.Name,
                AuthorId = model.AuthorId,
            };
            _context.Set<Book>().Add(book);
            await _context.SaveChangesAsync();
        }
        public async Task<List<BookViewModel>> GetAll()
        {
            var books = await _context.Books
                .Include(b => b.Author)
                .Select(b => new BookViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    AuthorId = b.AuthorId,
                    AuthorName = b.Author.Name
                })
                .ToListAsync();

            return books;
        }
        public async Task<List<BookViewModel>> GetAll_1()
        {
            var bookViewModels = from book in _context.Books
                                 join author in _context.Authors on book.AuthorId equals author.Id
                                 select new BookViewModel
                                 {
                                     Id = book.Id,
                                     Name = book.Name,
                                     AuthorId = book.AuthorId,
                                     AuthorName = author.Name
                                 };

            var result = await bookViewModels.ToListAsync();
            return result;
        }
        public async Task<Pagination<BookViewModel>> GetPagination(BookSearchQuery query)
        {
            var page = new Pagination<BookViewModel>();

            var booksQuery = _context.Books.Include(s => s.Author)
                .Select(b => new BookViewModel
                {
                    Id = b.Id,
                    Name = b.Name,
                    AuthorId = b.AuthorId,
                    AuthorName = b.Author.Name
                });

            if (!string.IsNullOrEmpty(query.Keyword))
            {
                booksQuery = booksQuery.Where(s => s.Name.Contains(query.Keyword));
            }

            if (query.AuthorId.HasValue)
            {
                booksQuery = booksQuery.Where(s => s.AuthorId == query.AuthorId.Value);
            }

            page.Total = await booksQuery.CountAsync();
            page.Data = await booksQuery.Skip(query.SkipNo).Take(query.PageSize).ToListAsync();

            return page;
        }
        public async Task DeleteAsync(Guid id)
        {
            var book = await _context.Set<Book>().FindAsync(id);
            if (book == null)
            {
                throw new Exception($"The book with id {id} is not found");
            }
            _context.Set<Book>().Remove(book);
            await _context.SaveChangesAsync();
        }
        public async Task<BookViewModel> GetById(Guid id)
        {
            var query = _context.Books.Include(s => s.Author);
            var book = await query.FirstOrDefaultAsync(s => s.Id == id);

            if (book == null)
            {
                throw new Exception("Book not found");
            }

            var result = new BookViewModel()
            {
                Id = book.Id,
                Name = book.Name,
                AuthorName = book.Author.Name,
                AuthorId = book.AuthorId
            };
            return result;
        }

        public async Task Update(UpdateBookViewModel model)
        {
            var book = await _context.Books.FindAsync(model.Id);
            if (book == null)
            {
                throw new Exception("Book not found");
            }
            book.Name = model.Name;
            book.AuthorId = model.AuthorId;
            _context.Set<Book>().Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            _context.Set<Book>().Remove(book);
            await _context.SaveChangesAsync();
        }

    }
}

