using Microsoft.EntityFrameworkCore;
using warmUp.Models;

namespace warmUp.Database
{
    public class ForgetAboutFreemanContext: DbContext
    {
        public ForgetAboutFreemanContext(DbContextOptions<ForgetAboutFreemanContext> options): base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
