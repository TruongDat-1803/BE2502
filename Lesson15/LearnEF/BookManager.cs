
//using LearnEF.Model.Authors;
//using LearnEF.Model.Books;
//using LearnEF.Services;


//namespace LearnEF
//{
//    public class BookManager
//    {
//        private readonly BookService _bookService;
//        private readonly AuthorService _authorService;

//        public BookManager()
//        {
//            _bookService = new BookService();
//        }
//        public void Init()
//        {
//            var check = true;
//            while (check)
//            {
//                Console.WriteLine("Please select an option: 1. Create Book ; 2. Update Book ; 3. Delete Book ; 4. List Book");
//                Console.WriteLine("5. Create Author ; 6. Update Author ; 7. Delete Author ; 8. List Author");
//                string input = Console.ReadLine() ?? "0";
//                int option;
//                if (!int.TryParse(input, out option))
//                {
//                    option = 0;
//                }
//                switch (option)
//                {
//                    case 1:
//                        Create();
//                        break;
//                    case 2:
//                        Update();
//                        break;
//                    case 3:
//                        Delete();
//                        break;
//                    case 4:
//                        GetAll();
//                        break;
//                    default:
//                        Console.WriteLine("Invalid option. Please try again.");
//                        continue;
//                }
//                Console.WriteLine("Do you want to continue? (y/n)");
//                string continueInput = Console.ReadLine() ?? "n";
//                if (continueInput.ToLower() != "n")
//                {
//                    check = true;
//                }
//            }
//        }
//        private void Create()
//        {
//            Console.WriteLine("Enter book name:");
//            string name = Console.ReadLine() ?? string.Empty;
//            Console.WriteLine("Enter author ID:");
//            string authorIdInput = Console.ReadLine() ?? string.Empty;
//            if (Guid.TryParse(authorIdInput, out Guid _authorId))
//            {
//                var _author = _authorService.GetById(_authorId);
//                _bookService.Create(new Model.Books.CreateBookViewModel { Name = name, AuthorId = _authorId, Author = _author });
//                Console.WriteLine("Book created successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid author ID.");
//            }
//        }
//        private void Update()
//        {
//            var bookUpdateModel = new UpdateBookViewModel();
//            Console.WriteLine("Enter book id to update:");
//            bookUpdateModel.Id = Guid.Parse(Console.ReadLine() ?? string.Empty);
//            Console.WriteLine("Enter book name to update:");
//            bookUpdateModel.BookName = Console.ReadLine() ?? string.Empty;
//            Console.WriteLine("Enter author ID to update:");
//            string authorIdInput = Console.ReadLine() ?? string.Empty;

//            if (Guid.TryParse(authorIdInput, out Guid _authorId))
//            {
//                var _author = _authorService.GetById(_authorId);
//                bookUpdateModel.AuthorId = _authorId;
//                bookUpdateModel.Author = _author;
//                _bookService.Update(bookUpdateModel);
//                Console.WriteLine("Book updated successfully.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid author ID.");
//            }
            
//        }
//    }
//}
