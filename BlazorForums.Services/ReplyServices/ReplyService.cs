using AutoMapper;
using BlazorForums.Data;
using BlazorForums.Data.Entities;
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

        public async Task<ReplyClientModel> Create(int postId, string userId, string content)
        {
            var user = await DataContext.Users.SingleOrDefaultAsync(user => user.Id == userId)
                ?? throw new KeyNotFoundException();

            var post = await DataContext.Posts.SingleOrDefaultAsync(post => post.Id == postId)
                ?? throw new KeyNotFoundException();

            var reply = new Reply
            {
                Content = content,
                Created = DateTime.Now,
                Post = post,
                User = user
            };

            await DataContext.Replies.AddAsync(reply);
            await DataContext.SaveChangesAsync();

            return Mapper.Map<ReplyClientModel>(reply);
        }

        public async Task<ReplyClientModel> Update(int replyId, string content)
        {
            var reply = await DataContext.Replies.SingleOrDefaultAsync(reply => reply.Id == replyId)
                ?? throw new KeyNotFoundException();

            reply.Content = content;

            this.DataContext.Replies.Update(reply);
            await this.DataContext.SaveChangesAsync();

            return Mapper.Map<ReplyClientModel>(reply);
        }

        // To not break the flow of a Post, instead of deleting the reply we will just 
        // set the message to deleted. 
        public async Task<ReplyClientModel> Delete(int replyId)
        {
            string message = "This message has been deleted.";
            return await this.Update(replyId, message);
        }

    }
}
