using Microsoft.EntityFrameworkCore;

namespace Program04.Models
{
        class Sbcontacts1 : DbContext
        {
            public DbSet<Student> Student { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server =(LocalDB)\\MSSQLLocalDB;Database=Swaptab;Trusted_Connection =True;");
            }

        
    }
}
