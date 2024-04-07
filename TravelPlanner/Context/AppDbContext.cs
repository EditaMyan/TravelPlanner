using Microsoft.EntityFrameworkCore;
using TravelPlanner.Data;

namespace TravelPlanner.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Trip> Trips { get; set; }

    }
}
