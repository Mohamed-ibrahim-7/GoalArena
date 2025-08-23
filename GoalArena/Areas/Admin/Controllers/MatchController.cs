using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MatchController : Controller
    {
        private readonly ImatchRepository _matchRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly ISeasonRepository _seasonRepository;
        private readonly ITournamentRepository _tournamentRepository;
        public MatchController(
            ImatchRepository matchRepository,
            ITeamRepository teamRepository,
            ISeasonRepository seasonRepository,
            ITournamentRepository tournamentRepository)
        {
            _matchRepository = matchRepository;
            _teamRepository = teamRepository;
            _seasonRepository = seasonRepository;
            _tournamentRepository = tournamentRepository;
        }

        public async Task<IActionResult> Index()
        {
            var matches = await _matchRepository.GetAsync(
                includes: [m => m.HomeTeam, m => m.AwayTeam, m => m.Season, m => m.Tournament]);
            return View(matches);
        }

        public async Task<IActionResult> Details(int id)
        {
            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == id,
                includes: [m => m.HomeTeam, m => m.AwayTeam, m => m.Season, m => m.Tournament]);
            if (match == null) return NotFound();
            return View(match);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var teams = await _teamRepository.GetAsync();
            var seasons = await _seasonRepository.GetAsync();
            var tournaments = await _tournamentRepository.GetAsync();

            ViewBag.HomeTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.AwayTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Seasons = seasons.Select(s => new SelectListItem { Value = s.SeasonId.ToString(), Text = s.Name }).ToList();
            ViewBag.Tournaments = tournaments.Select(t => new SelectListItem { Value = t.TournamentId.ToString(), Text = t.Name }).ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Match match)
        {
            if (ModelState.IsValid)
            {
                await _matchRepository.CreateAsync(match);
                await _matchRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }

            
            var teams = await _teamRepository.GetAsync();
            var seasons = await _seasonRepository.GetAsync();
            var tournaments = await _tournamentRepository.GetAsync();

            ViewBag.HomeTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.AwayTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Seasons = seasons.Select(s => new SelectListItem { Value = s.SeasonId.ToString(), Text = s.Name }).ToList();
            ViewBag.Tournaments = tournaments.Select(t => new SelectListItem { Value = t.TournamentId.ToString(), Text = t.Name }).ToList();

            return View(match);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var match = await _matchRepository.GetOneAsync(m => m.MatchId == id);
            if (match == null) return NotFound();

            var teams = await _teamRepository.GetAsync();
            var seasons = await _seasonRepository.GetAsync();
            var tournaments = await _tournamentRepository.GetAsync();

            ViewBag.HomeTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.AwayTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Seasons = seasons.Select(s => new SelectListItem { Value = s.SeasonId.ToString(), Text = s.Name }).ToList();
            ViewBag.Tournaments = tournaments.Select(t => new SelectListItem { Value = t.TournamentId.ToString(), Text = t.Name }).ToList();

            return View(match);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Match match)
        {
            if (id != match.MatchId) return NotFound();

            if (ModelState.IsValid)
            {
                _matchRepository.Edit(match);
                await _matchRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }

            
            var teams = await _teamRepository.GetAsync();
            var seasons = await _seasonRepository.GetAsync();
            var tournaments = await _tournamentRepository.GetAsync();

            ViewBag.HomeTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.AwayTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Seasons = seasons.Select(s => new SelectListItem { Value = s.SeasonId.ToString(), Text = s.Name }).ToList();
            ViewBag.Tournaments = tournaments.Select(t => new SelectListItem { Value = t.TournamentId.ToString(), Text = t.Name }).ToList();

            return View(match);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var match = await _matchRepository.GetOneAsync(m => m.MatchId == id);
            if (match == null) return NotFound();

            _matchRepository.Delete(match);
            await _matchRepository.CommitAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
