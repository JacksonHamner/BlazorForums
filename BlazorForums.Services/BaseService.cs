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

        public BaseService(IDbContext DataContext)
        {
                this.DataContext = DataContext;
        }
    }
}
