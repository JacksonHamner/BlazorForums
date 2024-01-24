using AutoMapper;
using BlazorForums.Data;
using BlazorForums.Services.ReplyServices.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorForums.Services.ReplyServices
{
    public class ReplyService : BaseService<ApplicationDbContext>, IReplyService
    {
        public ReplyService(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }

        public async Task<IEnumerable<ReplyClientModel>> GetAsync(int postId)
        {
            var replies = await DataContext.Replies
                .Include(reply => reply.Post)
                .Include(reply => reply.User)
                .Where(reply => reply.Post.Id == postId)
                .ToListAsync();

            return Mapper.Map<IEnumerable<ReplyClientModel>>(replies);
        }

    }
}
