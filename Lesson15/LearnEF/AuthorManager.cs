using BookApp.Model.Authors;
using BookApp.Model.Books;
using BookApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
{
    public class AuthorManager
    {
        private readonly AuthorService _authorService;
        private readonly BookService _bookService;
        public AuthorManager()
        {
            _authorService = new AuthorService();
            _bookService = new BookService();
        }
        public void Init()
        {
            var check = true;
            while (check)
            {
                Console.WriteLine("Please select an option: 1. Create Author ; 2. Update Author ; 3. Delete Author ; 4. List Author");
                Console.WriteLine("5. Create Book ; 6. Update Book ; 7. Delete Book ; 8. List Book");
                string input = Console.ReadLine() ?? "0";
                int option;

                if (!int.TryParse(input, out option))
                {
                    option = 0;
                }
                switch (option)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Update();
                        break;
                    case 3:
                        Delete();
                        break;
                    case 4:
                        GetAll();
                        break;
                    case 5:
                        CreateBook();
                        break;
                    //case 6:
                    //    UpdateBook();
                    //    break;
                    //case 7:
                    //    DeleteBook();
                    //    break;
                    case 8:
                        GetAllBooks();
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        continue;
                }
                Console.WriteLine("Do you want to continue? (y/n)");
                string continueInput = Console.ReadLine() ?? "n";
                if (continueInput.ToLower() != "n")
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }

        }
        private void Create()
        {
            Console.WriteLine("Add author");
            var authorCreateModel = new CreateAuthorViewModel();
            Console.WriteLine("Enter author name:");
            authorCreateModel.Name = Console.ReadLine() ?? string.Empty;
            try
            {
                _authorService.Create(authorCreateModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private void CreateBook()
        {             
            Console.WriteLine("Add book");
            // Similar to Create method, but for books
            var bookCreateModel = new CreateBookViewModel();
            Console.WriteLine("Enter book name:");
            bookCreateModel.Name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Enter author id for the book:");
            bookCreateModel.AuthorId = Guid.Parse(Console.ReadLine() ?? string.Empty);
            try
            {
                _bookService.Create(bookCreateModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        private void GetAll()
        {
            var result = _authorService.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
                var listBooks = _authorService.GetAllBooks(item.Id);
                foreach (var book in listBooks)
                {
                    Console.WriteLine($"    Book Id: {book.Id} - Book Name: {book.Name} - Author Name: {book.AuthorName}");
                }
            }
        }
        private void GetAll_AuthorAndBook()
        {
            var result = _authorService.GetAll_AuthorAndBook();
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Id} - {item.Name}");
                if (item.Books != null && item.Books.Any())
                {
                    foreach (var book in item.Books)
                    {
                        Console.WriteLine($"    Book Name: {book}");
                    }
                }
            }
        }
        private void GetAllBooks()
        {
            var query = new BookSearchQuery();
            query.PageSize = 2;
            var result = _bookService.GetPagination(query);
            Console.WriteLine();
            foreach (var item in result.Data)
            {
                Console.WriteLine($"Id: {item.Id} - Name: {item.Name} - AuthorName: {item.AuthorName}");
            }
            Console.WriteLine($"total page: {result.Total}");
        }
        private void Update()
        {
            var authorUpdateModel = new UpdateAuthorViewModel();
            Console.WriteLine("Enter author id to update:");
            authorUpdateModel.Id = Guid.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter author name to update:");
            authorUpdateModel.Name = Console.ReadLine() ?? string.Empty;
            _authorService.Update(authorUpdateModel);
        }
        private void Delete()
        {
            Console.WriteLine("Enter author id to delete:");
            Guid authorId = Guid.Parse(Console.ReadLine() ?? string.Empty);
            _authorService.Delete(authorId);
        }
    }
}
