using BookApp.Entities;
using BookApp.Models.Authors;
using BookApp.Models.Books;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookApp.Services
{
    public class AuthorService
    {
        private readonly DemoDbContext _context;
        public AuthorService(DemoDbContext context)
        {
            _context = context;
        }
        public void Create(CreateAuthorViewModel model)
        {
            var author = new Author { Name = model.Name, Id = new Guid() };
            _context.Set<Author>().Add(author); // insert Author () values()...
            _context.SaveChanges();
        }

        public void Update(UpdateAuthorViewModel model)
        {
            // select * from Authors where Id = model.Id
            var author = _context.Set<Author>().FirstOrDefault(s => s.Id == model.Id);
            if (author == null)
            {
                throw new Exception($"The author with id {model.Id} is not found");
            }
            author.Name = model.Name;
            _context.Set<Author>().Update(author);
            _context.SaveChanges();
        }
        public List<AuthorViewModel> GetAll()
        {
            var authors = _context.Set<Author>().ToList();
            var authorViewModels = authors.Select(s => new AuthorViewModel
            {
                Id = s.Id,
                Name = s.Name,
            }).ToList();
            return authorViewModels;
        }
        public List<AuthorViewModel> GetAll_AuthorAndBook()
        {
            var authors = _context.Authors.Include(a => a.Books)
                .Select(s => new AuthorViewModel
                {
                Id = s.Id,
                Name = s.Name,
                Books = s.Books.Select(b => b.Name).ToList()
            });

            return authors.ToList();
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
        public void Delete(Guid id)
        {
            // select * from Authors where Id = id
            var author = _context.Set<Author>().FirstOrDefault(s => s.Id == id);
            if (author == null)
            {
                throw new Exception($"The author with id {id} is not found");
            }
            _context.Set<Author>().Remove(author);
            _context.SaveChanges();
        }

        public Author GetById(Guid id)
        {
            // select * from Authors where Id = id
            var author = _context.Set<Author>().FirstOrDefault(s => s.Id == id);
            if (author == null)
            {
                throw new Exception($"The author with id {id} is not found");
            }
            return author;
        }
    }
}
