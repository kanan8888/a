using Microsoft.AspNetCore.Mvc;
using WebApp_26bovember.DAL;

namespace WebApp_26bovember.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {

        AppDbContext _db;
        public DashboardController(AppDbContext db)
        {
            _db = db;
        }

 
        public IActionResult Index()
        {
            return View();
        }





    }
}