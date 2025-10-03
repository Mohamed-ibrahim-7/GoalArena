using GoalArena.Data;
using GoalArena.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
     .Include(m => m.HomeTeam)
     .Include(m => m.AwayTeam)
     .Where(m => m.MatchDate >= DateTime.Now)  
     .OrderBy(m => m.MatchDate)                 
     .ToList();



            var news = _context.News
                               .OrderByDescending(n => n.Id)
                               .Take(5) 
                               .ToList();

            ViewBag.Matches = matches;
            ViewBag.News = news;
            ViewBag.CurrentFilter = dateFilter;
            ViewBag.FilterDate = filterDate;
            var topScorers = _context.Players
                  .Where(p => p.Goals > 0)
                  .Include(p => p.Team)
                  .OrderByDescending(p => p.Goals)   
                   .Take(5)                           
                   .ToList();
            ViewBag.TopScorers = topScorers;
            return View();
        }

        //[HttpPost]
        //public IActionResult PredictBestPlayer(string matchId, string playerName)
        //{
        //    TempData["Message"] = $"تم تسجيل توقعك: {playerName} للمباراة {matchId}";
        //    return RedirectToAction("Index");
        //}

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