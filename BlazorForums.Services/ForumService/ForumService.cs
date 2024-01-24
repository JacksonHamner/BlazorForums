using BlazorForums.Data;
using BlazorForums.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorForums.Services.ForumService
{
    public class ForumService : BaseService<ApplicationDbContext>, IForumService
    {

        public ForumService(ApplicationDbContext context)
            : base(context) { }


        public async Task<IEnumerable<Forum>> GetAsync()
        {
            return await this.DataContext.Forums.ToListAsync();
        }

    }
}
