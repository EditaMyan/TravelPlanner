using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Trip> Trips { get; set; }
        
    }
}
