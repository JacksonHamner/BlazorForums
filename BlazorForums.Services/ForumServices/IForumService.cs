using BlazorForums.Services.ForumServices.Models;

namespace BlazorForums.Services.ForumServices
{
    public interface IForumService
    {
        Task<IEnumerable<ForumClientModel>> GetAsync();
        Task<ForumClientModel> GetByIdAsync(int forumId);
        Task<ForumClientModel> Create(string Title, string Description, int Order);
        Task<ForumClientModel> Update(int forumId, string Title, string Description, int Order);
        Task Delete(int forumId);

    }
}
