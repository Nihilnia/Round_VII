using _1_warmUp.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_warmUp.Database
{
    public class LilyContext: DbContext
    {
        public LilyContext(DbContextOptions<LilyContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
