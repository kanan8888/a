using Microsoft.AspNetCore.Mvc;
using WebApp_26bovember.DAL;
using WebApp_26bovember.Models;

namespace WebApp_26bovember.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DrinkController:Controller
    {

        AppDbContext _db;
        public DrinkController(AppDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Drink drink)
        {

            return RedirectToAction("Index");
        }









    }
}
