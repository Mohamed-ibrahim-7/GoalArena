using GoalArena.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoalArena.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ عرض المباريات القادمة
        public IActionResult Index()
        {
            var matches = _context.Matches
                .Include(m => m.HomeTeam)
                .Include(m => m.AwayTeam)
                .Where(m => m.MatchDate >= DateTime.Now)
                .OrderBy(m => m.MatchDate)
                .ToList();

            ViewBag.Matches = matches;
            return View();
        }

        // ✅ تفاصيل مباراة
        public IActionResult Details(int id)
        {
            var match = _context.Matches
                .Include(m => m.HomeTeam)
                .Include(m => m.AwayTeam)
                .FirstOrDefault(m => m.MatchId == id);

            if (match == null) return NotFound();

            return View(match);
        }
    }
}
