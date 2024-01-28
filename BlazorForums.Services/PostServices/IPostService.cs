using BlazorForums.Services.PostServices.Models;

namespace BlazorForums.Services.PostServices
{
    public interface IPostService
    {
        Task<IEnumerable<PostClientModel>> GetAsync(int forumId);
        Task<PostClientModel> GetByIdAsync(int postId);
        Task<PostClientModel> Create(int forumId, string userId, string title, string content);
        Task<PostClientModel> Update(int forumId, int postId, string title, string content);
        Task Delete(int postId);
    }
}