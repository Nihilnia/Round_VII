using Apollyon.Models;
using Microsoft.EntityFrameworkCore;

namespace Apollyon.Database
{
    public class ApollyonContext: DbContext
    {
        public ApollyonContext(DbContextOptions<ApollyonContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
