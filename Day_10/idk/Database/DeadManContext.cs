using idk.Models;
using Microsoft.EntityFrameworkCore;

namespace idk.Database
{
    public class DeadManContext: DbContext
    {
        public DeadManContext(DbContextOptions<DeadManContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
