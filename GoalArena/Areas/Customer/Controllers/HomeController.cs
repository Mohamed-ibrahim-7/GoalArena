using GoalArena.Data;
using GoalArena.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoalArena.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string dateFilter = "today")
        {
            DateTime today = DateTime.Today;
            DateTime filterDate = dateFilter.ToLower() switch
            {
                "yesterday" => today.AddDays(-1),
                "tomorrow" => today.AddDays(1),
                _ => today // default to today
            };

            var matches = _context.Matches
                                   .Where(m => m.MatchDate.Date == filterDate)
                                   .OrderByDescending(m => m.MatchDate)
                                   .ToList();

            var news = _context.News
                               .OrderByDescending(n => n.Id)
                               .Take(5) // أخذ آخر 5 أخبار
                               .ToList();

            ViewBag.Matches = matches;
            ViewBag.News = news;
            ViewBag.CurrentFilter = dateFilter;
            ViewBag.FilterDate = filterDate;

            return View();
        }

        [HttpPost]
        public IActionResult PredictBestPlayer(string matchId, string playerName)
        {
            TempData["Message"] = $"تم تسجيل توقعك: {playerName} للمباراة {matchId}";
            return RedirectToAction("Index");
        }

        //public IActionResult BookTicket(string matchId)
        //{
        //    var match = _context.Matches.FirstOrDefault(m => m.MatchId.ToString() == matchId);
        //    if (match == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(match);
        //}

        //[HttpPost]
        //public IActionResult BookTicketConfirmed(string matchId)
        //{
        //    TempData["Message"] = $"تم حجز تذكرة للمباراة {matchId}";
        //    return RedirectToAction("Index");
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}