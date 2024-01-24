using BlazorForums.Data.Entities;
using BlazorForums.Services.ForumServices.Models;

namespace BlazorForums.Services.ForumServices
{
    public interface IForumService
    {
        Task<IEnumerable<ForumClientModel>> GetAsync();
        Task<ForumClientModel> GetByIdAsync(int forumId);
    }
}
