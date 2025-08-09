using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SeasonsController : Controller
    {
        private readonly ISeasonRepository _seasonRepository;
        private readonly ITournamentRepository _tournamentRepository;

        public SeasonsController(ISeasonRepository seasonRepository, ITournamentRepository tournamentRepository)
        {
            _seasonRepository = seasonRepository;
            _tournamentRepository = tournamentRepository;
        }

        
        public async Task<IActionResult> Index()
        {
            
            var seasons = await _seasonRepository.GetAsync(null, new Expression<Func<Season, object>>[] { s => s.Tournament });

            return View(seasons);
        }

        
        public async Task<IActionResult> Details(int id)
        {
            
            var season = await _seasonRepository.GetOneAsync(s => s.SeasonId == id, new Expression<Func<Season, object>>[] { s => s.Tournament });
            if (season == null) return NotFound();
            return View(season);
        }

        
        public async Task<IActionResult> Create()
        {
            var tournaments = await _tournamentRepository.GetAsync();
            ViewBag.TournamentList = tournaments.Select(t => new SelectListItem
            {
                Value = t.TournamentId.ToString(),
                Text = t.Name
            }).ToList();

            ViewBag.StatusList = Enum.GetValues(typeof(SeasonStatus))
                .Cast<SeasonStatus>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString()
                }).ToList();

            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Season season)
        {
            if (ModelState.IsValid)
            {
                await _seasonRepository.CreateAsync(season);
                await _seasonRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }

           
            var tournaments = await _tournamentRepository.GetAsync();
            ViewBag.TournamentList = tournaments.Select(t => new SelectListItem
            {
                Value = t.TournamentId.ToString(),
                Text = t.Name
            }).ToList();
            ViewBag.StatusList = Enum.GetValues(typeof(SeasonStatus))
                .Cast<SeasonStatus>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString()
                }).ToList();

            return View(season);
        }

       
        public async Task<IActionResult> Edit(int id)
        {
            var season = await _seasonRepository.GetOneAsync(s => s.SeasonId == id);
            if (season == null) return NotFound();

            var tournaments = await _tournamentRepository.GetAsync();
            ViewBag.TournamentList = tournaments.Select(t => new SelectListItem
            {
                Value = t.TournamentId.ToString(),
                Text = t.Name
            }).ToList();
            ViewBag.StatusList = Enum.GetValues(typeof(SeasonStatus))
                .Cast<SeasonStatus>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString()
                }).ToList();

            return View(season);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Season season)
        {
            if (id != season.SeasonId) return NotFound();

            var existingSeason = await _seasonRepository.GetOneAsync(s => s.SeasonId == id);
            if (existingSeason == null) return NotFound();

            if (ModelState.IsValid)
            {
                existingSeason.Name = season.Name;
                existingSeason.StartDate = season.StartDate;
                existingSeason.EndDate = season.EndDate;
                existingSeason.TournamentId = season.TournamentId;
                existingSeason.Status = season.Status;

                _seasonRepository.Edit(existingSeason);
                await _seasonRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }

            var tournaments = await _tournamentRepository.GetAsync();
            ViewBag.TournamentList = tournaments.Select(t => new SelectListItem
            {
                Value = t.TournamentId.ToString(),
                Text = t.Name
            }).ToList();
            ViewBag.StatusList = Enum.GetValues(typeof(SeasonStatus))
                .Cast<SeasonStatus>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString()
                }).ToList();

            return View(season);
        }

        
        public async Task<IActionResult> Delete(int id)
        {
            var season = await _seasonRepository.GetOneAsync(s => s.SeasonId == id, new Expression<Func<Season, object>>[] { s => s.Tournament }); if (season == null) return NotFound();
            return View(season);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var season = await _seasonRepository.GetOneAsync(s => s.SeasonId == id);
            if (season != null)
            {
                _seasonRepository.Delete(season);
                await _seasonRepository.CommitAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
