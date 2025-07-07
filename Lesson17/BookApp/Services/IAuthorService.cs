using BookApp.Entities;
using BookApp.Models.Authors;

namespace BookApp.Services
{
    public interface IAuthorService
    {
        Task Create(CreateAuthorViewModel model);
        Task Update(UpdateAuthorViewModel model);
        Task<List<AuthorViewModel>> GetAll();
        Task<List<AuthorViewModel>> GetAll_AuthorAndBook();
        Task<AuthorViewModel> GetById(Guid id);
        Task Delete(Guid id);
    }
}
