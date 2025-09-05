using GoalArena.Data;
using GoalArena.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =$"{SD.SuperAdmin},{SD.Admin}")]
    
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.TotalSeasons = _context.Seasons.Count();
            ViewBag.TotalTeams = _context.Teams.Count();
            ViewBag.TotalTournaments = _context.Tournaments.Count();
            ViewBag.totalPlayers = _context.Players.Count();
            ViewBag.totalNews = _context.News.Count();



            var standings = _context.TeamSeasons
        .Include(ts => ts.Team)
        .ToList() 
        .OrderByDescending(ts => ts.Points)
        .ThenByDescending(ts => ts.GoalsFor - ts.GoalsAgainst) 
        .ThenByDescending(ts => ts.GoalsFor)
        .ToList();

            ViewBag.Standings = standings;




            return View();
        }
    }
}