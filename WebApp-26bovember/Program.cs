using Microsoft.EntityFrameworkCore;
using WebApp_26bovember.DAL;

namespace WebApp_26bovember
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer("server=DESKTOP-GTVND9D;database=26novemberAdminPanell;Trusted_connection=true;Encrypt=false"));

            var app = builder.Build();


            app.MapControllerRoute(
                name:"areas",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                name: "defoult",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.UseStaticFiles();
            app.Run();
        }
    }
}
