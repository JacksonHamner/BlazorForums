using BlazorForums.Services.PostServices.Models;

namespace BlazorForums.Services.PostServices
{
    public interface IPostService
    {
        Task<IEnumerable<PostClientModel>> GetAsync(int ForumId);
        Task<PostClientModel> GetByIdAsync(int postId);
    }
}