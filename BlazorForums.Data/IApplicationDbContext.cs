using BlazorForums.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorForums.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Forum> Forums { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Reply> Replies { get; set; }
    }
}