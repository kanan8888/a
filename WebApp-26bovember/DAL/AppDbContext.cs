using Microsoft.EntityFrameworkCore;
using WebApp_26bovember.Models;

namespace WebApp_26bovember.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<Drink> Drinks {  get; set; } 
        public DbSet<DrinkCategory> DrinkCategorys { get; set; }
        public DbSet<SpecialItem> SpecialItems { get; set; }




    }
}
