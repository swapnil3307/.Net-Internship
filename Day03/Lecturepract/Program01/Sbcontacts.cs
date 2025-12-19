using Microsoft.EntityFrameworkCore;

namespace Program01
{
    class Sbcontacts : DbContext
{
    public DbSet<Student> Student { get; set; }

    public DbSet<Course> Course { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server =(LocalDB)\\MSSQLLocalDB;Database=Swapinfo;Trusted_Connection =True;");
    }

}
}

