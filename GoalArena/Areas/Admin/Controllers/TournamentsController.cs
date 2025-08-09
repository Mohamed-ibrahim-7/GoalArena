using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TournamentsController : Controller
    {
        private readonly ITournamentRepository _tournamentRepository;

        public TournamentsController(ITournamentRepository tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

    
        public async Task<IActionResult> Index()
        {
            var tournaments = await _tournamentRepository.GetAsync();
            return View(tournaments);
        }

      
        public async Task<IActionResult> Details(int id)
        {
            var tournament = await _tournamentRepository.GetOneAsync(t => t.TournamentId == id);

            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        
        public IActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Tournament tournament)
        {
            if (ModelState.IsValid)
            {
                var logoFile = Request.Form.Files["LogoFile"];
                if (logoFile != null && logoFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "tournaments");
                    Directory.CreateDirectory(uploadsFolder);
                    var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(logoFile.FileName);
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await logoFile.CopyToAsync(stream);
                    }

                    tournament.LogoUrl = "/uploads/tournaments/" + uniqueFileName;
                }
                else
                {
                    tournament.LogoUrl = string.Empty;
                }

                await _tournamentRepository.CreateAsync(tournament);
                await _tournamentRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tournament);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var tournament = await _tournamentRepository.GetOneAsync(t => t.TournamentId == id);

            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Tournament tournament)
        {
            if (id != tournament.TournamentId)
                return NotFound();

            var existingTournament = await _tournamentRepository.GetOneAsync(t => t.TournamentId == id);
            if (existingTournament == null)
                return NotFound();

            if (ModelState.IsValid)
            {
               
                var logoFile = Request.Form.Files["LogoFile"];
                if (logoFile != null && logoFile.Length > 0)
                {
                   
                    if (!string.IsNullOrEmpty(existingTournament.LogoUrl))
                    {
                        var oldLogoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", existingTournament.LogoUrl.TrimStart('/'));
                        if (System.IO.File.Exists(oldLogoPath))
                            System.IO.File.Delete(oldLogoPath);
                    }

                 
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "tournaments");
                    Directory.CreateDirectory(uploadsFolder);
                    var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(logoFile.FileName);
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await logoFile.CopyToAsync(stream);
                    }

                    existingTournament.LogoUrl = "/uploads/tournaments/" + uniqueFileName;
                }
                

                
                existingTournament.Name = tournament.Name;
                existingTournament.Country = tournament.Country;

                _tournamentRepository.Edit(existingTournament);
                await _tournamentRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tournament);
        }


        
        public async Task<IActionResult> Delete(int id)
        {
            var tournament = await _tournamentRepository.GetOneAsync(t => t.TournamentId == id);

            if (tournament == null)
            {
                return NotFound();
            }

            return View(tournament);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tournament = await _tournamentRepository.GetOneAsync(t => t.TournamentId == id);
            if (tournament != null)
            {
                
                if (!string.IsNullOrEmpty(tournament.LogoUrl))
                {
                    var logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", tournament.LogoUrl.TrimStart('/'));
                    if (System.IO.File.Exists(logoPath))
                        System.IO.File.Delete(logoPath);
                }

                _tournamentRepository.Delete(tournament);
                await _tournamentRepository.CommitAsync();
            }
            return RedirectToAction(nameof(Index));
        }

    }
}
