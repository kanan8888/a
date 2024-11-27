using Microsoft.AspNetCore.Mvc;
using WebApp_26bovember.DAL;
using WebApp_26bovember.Models;

namespace WebApp_26bovember.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController:Controller
    {

        AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() 
        {
            return  View();
        }
        public IActionResult Create(DrinkCategory drinkCategory)
        {

            return RedirectToAction("Index");
        }





    }

}

