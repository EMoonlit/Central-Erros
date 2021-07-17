using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Central_Errors_1.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb=CentralErros;Integrated Security=True");
        }
    }
}
