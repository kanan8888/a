using Microsoft.AspNetCore.Mvc;
using WebApp_26bovember.DAL;
using WebApp_26bovember.Models;

namespace WebApp_26bovember.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            List<Drink> drinks = _db.Drinks.ToList();
            List<DrinkCategory> drinkCategories = _db.DrinkCategorys.ToList();
            List<SpecialItem> specialItems = _db.SpecialItems.ToList();


            ViewBag.Drinks = (drinks);
            ViewBag.DrinkCategories = (drinkCategories);
            ViewBag.SpecialItems = (specialItems);
            return View();
        }
    }
}