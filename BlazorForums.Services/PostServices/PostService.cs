﻿using AutoMapper;
using BlazorForums.Data;
using BlazorForums.Services.PostServices.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorForums.Services.PostServices
{
    public class PostService : BaseService<ApplicationDbContext>, IPostService
    {

        public PostService(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }


        public async Task<IEnumerable<PostClientModel>> GetAsync(int forumId)
        {
            var posts = await DataContext.Posts
                .Include(post => post.Forum)
                .Include(post => post.User)
                .Where(post => post.Forum.Id == forumId)
                .ToListAsync();

            return Mapper.Map<IEnumerable<PostClientModel>>(posts);
        }

        public async Task<PostClientModel> GetByIdAsync(int postId)
        {
            var post = await DataContext.Posts
                .Include(post => post.Forum)
                .Include(post => post.User)
                .SingleOrDefaultAsync(post => post.Id == postId) ?? throw new KeyNotFoundException();

            return Mapper.Map<PostClientModel>(post);
        }

    }
}
