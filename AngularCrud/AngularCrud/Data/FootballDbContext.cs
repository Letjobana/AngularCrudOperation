using AngularCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularCrud.Data
{
    public class FootballDbContext : DbContext
    {
        public FootballDbContext(DbContextOptions<FootballDbContext> options) : base(options)
        {

        }
        public DbSet<Players> GetPlayers { get; set; }
        public DbSet<Positions> GetPostitions { get; set; }
    }
}
