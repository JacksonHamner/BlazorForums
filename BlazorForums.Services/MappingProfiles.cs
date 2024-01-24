using AutoMapper;
using BlazorForums.Data.Entities;
using BlazorForums.Services.ForumServices.Models;
using BlazorForums.Services.PostServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorForums.Services
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Forum, ForumClientModel>().ReverseMap();

            CreateMap<Post, PostClientModel>()
                .ForMember(x => x.UserId, p => p.MapFrom(p => p.User.Id))
                .ForMember(x => x.UserName, p => p.MapFrom(p => p.User.UserName))
                .ForMember(x => x.ForumId, p => p.MapFrom(p => p.Forum.Id));

            CreateMap<PostClientModel, Post>()
                .ForMember(x => x.User, p => p.Ignore())
                .ForMember(x => x.Forum, p => p.Ignore());
        }
    }
}
