using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNet.Models;

namespace SuperHeroAPI_DotNet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
