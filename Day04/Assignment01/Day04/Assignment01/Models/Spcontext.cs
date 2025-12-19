using Microsoft.EntityFrameworkCore;

namespace Assignment01.Models
{
    public class Spcontext : DbContext
    {
      public DbSet<Student>Student {  get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =(LocalDB)\\MSSQLLocalDB;Database=SwapAss04;Trusted_Connection =True;");
        }
    }
}
