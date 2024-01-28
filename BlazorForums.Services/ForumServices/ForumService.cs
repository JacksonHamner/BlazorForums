using AutoMapper;
using BlazorForums.Data;
using BlazorForums.Services.ForumServices.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorForums.Services.ForumServices
{
    public class ForumService : BaseService<ApplicationDbContext>, IForumService
    {

        public ForumService(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }

        public Task<ForumClientModel> Create(string Title, string Description, int Order)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int forumId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ForumClientModel>> GetAsync()
        {
            return await DataContext.Forums
                .Select(forum => Mapper.Map<ForumClientModel>(forum))
                .ToListAsync();
        }

        public async Task<ForumClientModel> GetByIdAsync(int forumId)
        {
            var forum = await DataContext.Forums
                .SingleOrDefaultAsync(forum => forum.Id == forumId) ?? throw new KeyNotFoundException();
            return Mapper.Map<ForumClientModel>(forum);
        }

        public Task<ForumClientModel> Update(int forumId, string Title, string Description, int Order)
        {
            throw new NotImplementedException();
        }
    }
}
