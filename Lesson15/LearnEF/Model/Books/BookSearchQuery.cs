namespace BookApp.Model.Books
{
    public class BookSearchQuery : SearchQuery
    {
        public Guid? AuthorId { get; set; }
    }
}
