﻿using AutoMapper;
using BlazorForums.Data;
using BlazorForums.Data.Entities;
using BlazorForums.Services.ForumServices.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorForums.Services.ForumServices
{
    public class ForumService : BaseService<ApplicationDbContext>, IForumService
    {

        public ForumService(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper) { }


        public async Task<IEnumerable<ForumClientModel>> GetAsync()
        {
            return await DataContext.Forums
                .Select(x => Mapper.Map<ForumClientModel>(x))
                .ToListAsync();
        }

    }
}
