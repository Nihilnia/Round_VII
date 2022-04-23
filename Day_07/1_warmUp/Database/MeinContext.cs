using _1_warmUp.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_warmUp.Database
{
    public class MeinContext: DbContext
    {
        public MeinContext(DbContextOptions<MeinContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}