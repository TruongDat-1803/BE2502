using BookApp.Models;
using BookApp.Models.Books;

namespace BookApp.Services
{
    public interface IBookService
    {
        Task Create(CreateBookViewModel model);
        Task<List<BookViewModel>> GetAll();
        Task<List<BookViewModel>> GetAll_1();
        Task<Pagination<BookViewModel>> GetPagination(BookSearchQuery query);
        Task DeleteAsync(Guid id);
        Task<BookViewModel> GetById(Guid id);
        Task Update(UpdateBookViewModel model);
        Task Delete(Guid id);

    }
}
