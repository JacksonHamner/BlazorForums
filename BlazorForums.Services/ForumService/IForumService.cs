using BlazorForums.Data.Entities;

namespace BlazorForums.Services.ForumService
{
    public interface IForumService
    {
        Task<IEnumerable<Forum>> GetAsync();
    }
}
