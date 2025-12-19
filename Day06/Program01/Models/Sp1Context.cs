using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Program01.Models
{
    public  class Sp1Context : DbContext
        {
            public DbSet<Student> Student { get; set; }
            public DbSet<Course> Courses { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server =(LocalDB)\\MSSQLLocalDB;Database=Swapday5;Trusted_Connection =True;");
            }
        }
    }

