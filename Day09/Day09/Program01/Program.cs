using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Program01.Models;

namespace Program01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();



            builder.Services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer("Server =(LocalDB)\\MSSQLLocalDB;Database=ModelBuildingDB;Trusted_Connection =True;"));

            builder.Services.AddIdentity<AppUser, IdentityRole>()
                               .AddEntityFrameworkStores<ApplicationDbContext>();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                 IdentitySeed.SeedRolesAndAdmin(scope.ServiceProvider);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
