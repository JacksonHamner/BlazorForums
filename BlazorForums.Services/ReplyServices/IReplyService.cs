using BlazorForums.Services.ReplyServices.Models;

namespace BlazorForums.Services.ReplyServices
{
    public interface IReplyService
    {
        Task<IEnumerable<ReplyClientModel>> GetAsync(int postId);
        Task<ReplyClientModel> CreateReply(int postId, string userId, string content);
    }
}