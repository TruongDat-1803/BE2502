using BookApp.Entities;
using BookApp.Models.Authors;
using BookApp.Models.Books;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookApp.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly DemoDbContext _context;
        public AuthorService(DemoDbContext context)
        {
            _context = context;
        }
        public async Task Create(CreateAuthorViewModel model)
        {
            var author = new Author { Name = model.Name, Id = new Guid() };
            _context.Set<Author>().Add(author); 
            await _context.SaveChangesAsync();
        }

        public async Task Update(UpdateAuthorViewModel model)
        {
            // select * from Authors where Id = model.Id
            var author = _context.Set<Author>().FirstOrDefault(s => s.Id == model.Id);
            if (author == null)
            {
                throw new Exception($"The author with id {model.Id} is not found");
            }
            author.Name = model.Name;
            _context.Set<Author>().Update(author);
            await _context.SaveChangesAsync();
        }
        public async Task<List<AuthorViewModel>>GetAll()
        {
            var authors = _context.Authors;
            var authorViewModels = authors.Select(s => new AuthorViewModel 
            { 
                Name = s.Name, 
                Id = s.Id 
            });
            return await authorViewModels.ToListAsync();
        }
        public async Task<List<AuthorViewModel>> GetAll_AuthorAndBook()
        {
            var authors = _context.Authors.Include(a => a.Books)
                .Select(s => new AuthorViewModel
                {
                Id = s.Id,
                Name = s.Name,
                Books = s.Books.Select(b => b.Name).ToList()
            });
            return await authors.ToListAsync();
        }
        public List<BookViewModel> GetAllBooks(Guid _authorID)
        {
            var books = _context.Books.Include(s => s.Author)
                              .Where(b => b.AuthorId == _authorID)
                              .Select(b => new BookViewModel
                              {
                                  Id = b.Id,
                                  Name = b.Name,
                                  AuthorId = b.AuthorId,
                                  AuthorName = b.Author.Name
                              }).ToList();
            return books;
        }
        public async Task Delete(Guid id)
        {
            // select * from Authors where Id = id
            var author = _context.Set<Author>().FirstOrDefault(s => s.Id == id);
            if (author == null)
            {
                throw new Exception($"The author with id {id} is not found");
            }
            _context.Set<Author>().Remove(author);
            await _context.SaveChangesAsync();
        }

        public async Task<AuthorViewModel> GetById(Guid id)
        {
            var author = await _context.Authors.FindAsync(id);
            if (author == null)
            {
                throw new Exception("Author not found");
            }

            var result = new AuthorViewModel()
            {
                Id = author.Id,
                Name = author.Name,
            };
            return result;
        }
    }
}
