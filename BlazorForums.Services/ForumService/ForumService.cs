using BlazorForums.Data;
using BlazorForums.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorForums.Services.ForumService
{
    public class ForumService : IForumService
    {
        private readonly ApplicationDbContext context;
        public ForumService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Forum>> GetAsync()
        {
            return await context.Forums.ToListAsync();
        }
    }
}
