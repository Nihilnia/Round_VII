using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace warmUp.Models.Database
{
    public class NoWhereShopContext: DbContext
    {
        public DbSet<People> Peoples { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source  = .\SQLEXPRESS; Initial Catalog = NoWhereShop; Integrated Security = SSPI");
        }
    }
}