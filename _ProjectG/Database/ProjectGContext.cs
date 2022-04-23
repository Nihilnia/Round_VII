using Microsoft.EntityFrameworkCore;
using ProjectG.Models;

namespace ProjectG.Database
{
    public class ProjectGContext: DbContext
    {
        public ProjectGContext(DbContextOptions<ProjectGContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
