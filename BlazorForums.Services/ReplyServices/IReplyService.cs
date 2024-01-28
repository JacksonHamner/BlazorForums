using BlazorForums.Services.ReplyServices.Models;

namespace BlazorForums.Services.ReplyServices
{
    public interface IReplyService
    {
        Task<IEnumerable<ReplyClientModel>> GetAsync(int postId);
        Task<ReplyClientModel> Create(int postId, string userId, string content);
        Task<ReplyClientModel> Update(int replyId, string content);
        Task<ReplyClientModel> Delete(int replyId);
    }
}