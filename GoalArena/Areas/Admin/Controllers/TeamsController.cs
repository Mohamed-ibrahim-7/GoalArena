using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using GoalArena.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq.Expressions;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamsController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ISeasonRepository _seasonRepository;

        public TeamsController(ITeamRepository teamRepository, ISeasonRepository seasonRepository)
        {
            _teamRepository = teamRepository;
            _seasonRepository = seasonRepository;
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin},{SD.Company}")]
        public async Task<IActionResult> Index()
        {
            var teams = await _teamRepository.GetAsync(null, new Expression<Func<Team, object>>[] { t => t.Season }); return View(teams);
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Details(int id)
        {
            var team = await _teamRepository.GetOneAsync(t => t.Id == id,new Expression<Func<Team, object>>[] { t => t.Season });
            if (team == null) return NotFound();
            return View(team);
        }
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]

        public async Task<IActionResult> Create()
        {
            var seasons = await _seasonRepository.GetAsync();
            ViewBag.SeasonList = seasons.Select(s => new SelectListItem
            {
                Value = s.SeasonId.ToString(),
                Text = s.Name
            }).ToList();
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Create(Team team)
        {
            if (ModelState.IsValid)
            {
                var logoFile = Request.Form.Files["LogoFile"];
                if (logoFile != null && logoFile.Length > 0)
                {
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "teams");
                    Directory.CreateDirectory(uploadsFolder);
                    var uniqueFileName = Guid.NewGuid() + Path.GetExtension(logoFile.FileName);
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await logoFile.CopyToAsync(stream);
                    }
                    team.LogoUrl = "/uploads/teams/" + uniqueFileName;
                }
                else
                {
                    team.LogoUrl = string.Empty;
                }

                await _teamRepository.CreateAsync(team);
                await _teamRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }

            
            var seasons = await _seasonRepository.GetAsync();
            ViewBag.SeasonList = seasons.Select(s => new SelectListItem
            {
                Value = s.SeasonId.ToString(),
                Text = s.Name
            }).ToList();
            return View(team);
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit(int id)
        {
            var team = await _teamRepository.GetOneAsync(t => t.Id == id, new Expression<Func<Team, object>>[] { t => t.Season }); if (team == null) return NotFound();

            var seasons = await _seasonRepository.GetAsync();
            ViewBag.SeasonList = seasons.Select(s => new SelectListItem
            {
                Value = s.SeasonId.ToString(),
                Text = s.Name
            }).ToList();
            return View(team);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit(int id, Team team)
        {
            if (id != team.Id) return NotFound();

            var existingTeam = await _teamRepository.GetOneAsync(
                t => t.Id == id,
                new Expression<Func<Team, object>>[] { t => t.Season }
            );
            if (existingTeam == null) return NotFound();

            if (ModelState.IsValid)
            {
                var logoFile = Request.Form.Files["LogoFile"];
                if (logoFile != null && logoFile.Length > 0)
                {
                    if (!string.IsNullOrEmpty(existingTeam.LogoUrl))
                    {
                        var oldLogoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", existingTeam.LogoUrl.TrimStart('/'));
                        if (System.IO.File.Exists(oldLogoPath))
                            System.IO.File.Delete(oldLogoPath);
                    }

                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "teams");
                    Directory.CreateDirectory(uploadsFolder);
                    var uniqueFileName = Guid.NewGuid() + Path.GetExtension(logoFile.FileName);
                    var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await logoFile.CopyToAsync(stream);
                    }
                    existingTeam.LogoUrl = "/uploads/teams/" + uniqueFileName;
                }
                

                existingTeam.Name = team.Name;
                existingTeam.Coach = team.Coach;
                existingTeam.SeasonId = team.SeasonId;

                _teamRepository.Edit(existingTeam);
                await _teamRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }

            var seasons = await _seasonRepository.GetAsync();
            ViewBag.SeasonList = seasons.Select(s => new SelectListItem
            {
                Value = s.SeasonId.ToString(),
                Text = s.Name
            }).ToList();
            return View(team);
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Delete(int id)
        {
            
            var team = await _teamRepository.GetOneAsync(t => t.Id == id, new Expression<Func<Team, object>>[] { t => t.Season });

            if (team == null) return NotFound();
            return View(team);
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _teamRepository.GetOneAsync(t => t.Id == id, new Expression<Func<Team, object>>[] { t => t.Season });

            if (team != null)
            {
                if (!string.IsNullOrEmpty(team.LogoUrl))
                {
                    var logoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", team.LogoUrl.TrimStart('/'));
                    if (System.IO.File.Exists(logoPath))
                        System.IO.File.Delete(logoPath);
                }
                _teamRepository.Delete(team);
                await _teamRepository.CommitAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

