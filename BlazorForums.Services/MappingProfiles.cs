using AutoMapper;
using BlazorForums.Data.Entities;
using BlazorForums.Services.ForumServices.Models;
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
        }
    }
}
