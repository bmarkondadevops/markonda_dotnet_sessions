using Microsoft.EntityFrameworkCore;
using MVCRepositoryApp.Domain;

namespace MVCRepositoryApp.Data
{
    public class NITRKLDbContext:DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        public NITRKLDbContext(DbContextOptions<NITRKLDbContext> options):base(options)
        {

        }

    }
}
