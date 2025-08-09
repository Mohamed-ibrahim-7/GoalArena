using Microsoft.AspNetCore.Mvc;

namespace GoalArena.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
