namespace BookApp.Models.Books
{
    public class BookSearchQuery : SearchQuery
    {
        public Guid? AuthorId { get; set; }
    }
}
