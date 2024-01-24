using AutoMapper;
using BlazorForums.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorForums.Services
{
    public abstract class BaseService<IDbContext>
        where IDbContext : DbContext, IApplicationDbContext
    {
        protected IDbContext DataContext;
        protected readonly IMapper Mapper;

        public BaseService(IDbContext DataContext, IMapper Mapper)
        {
            this.DataContext = DataContext;
            this.Mapper = Mapper;
        }
    }
}
