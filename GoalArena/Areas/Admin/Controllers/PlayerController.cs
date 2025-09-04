using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using GoalArena.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlayerController : Controller
    {

        private readonly IPlayerRepository _playerRepository;
        private readonly ITeamRepository _teamRepository;

        public PlayerController(IPlayerRepository playerRepository, ITeamRepository teamRepository)
        {
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
        }
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin},{SD.Company}")]
        public async Task<IActionResult> Index()
        {
            var players =await _playerRepository.GetAsync(includes: [e => e.Team!]);
            return View(players);
        }
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Details(int id)
        {
            var players =await _playerRepository.GetOneAsync(e => e.PlayerId == id,includes: [e => e.Team!]);
            if (players == null) return NotFound();
            return View(players);

        }


        [HttpGet]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Create()
        {
            var teams = await _teamRepository.GetAsync();
            ViewBag.TeamList = teams.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = t.Name
            }).ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Create(Player player)
        {
           
                if (ModelState.IsValid)
                {
                    var imageFile = Request.Form.Files["LogoFile"];
                    if (imageFile != null && imageFile.Length > 0)
                    {
                        var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "players");
                        Directory.CreateDirectory(uploadsFolder);
                        var uniqueFileName = Guid.NewGuid() + Path.GetExtension(imageFile.FileName);
                        var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await imageFile.CopyToAsync(stream);
                        }
                        player.ImageUrl = "/uploads/players/" + uniqueFileName;
                    }
                    else
                    {
                        player.ImageUrl = string.Empty;
                    }
                    {
                    
                 
                    await _playerRepository.CreateAsync(player);
                    await _playerRepository.CommitAsync();
                    return RedirectToAction(nameof(Index));
                    }
                }
                    var teams = await _teamRepository.GetAsync();
                    ViewBag.TeamList = teams.Select(t => new SelectListItem
                    {
                        Value = t.Id.ToString(),
                        Text = t.Name
                    }).ToList();
                    return View(player);
        }
        

        [HttpGet]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit(int id)
        {
            var player = await _playerRepository.GetOneAsync(e => e.PlayerId == id, includes: [e => e.Team!]);
            if (player == null) return NotFound();
            var teams = await _teamRepository.GetAsync();
            ViewBag.TeamList = teams.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = t.Name
            }).ToList();
            return View(player);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit(Player player)
        {
            if (!ModelState.IsValid)
            {
                
                var teams = await _teamRepository.GetAsync();
                ViewBag.TeamList = teams.Select(t => new SelectListItem
                {
                    Value = t.Id.ToString(),
                    Text = t.Name
                }).ToList();
                
                return View(player);
            }
            var imageFile = Request.Form.Files["LogoFile"];
            if (imageFile != null && imageFile.Length > 0)
            {
                if (!string.IsNullOrEmpty(player.ImageUrl))
                {
                    var oldImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", player.ImageUrl.TrimStart('/'));
                    if (System.IO.File.Exists(oldImagePath))
                        System.IO.File.Delete(oldImagePath);
                }

                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "players");
                Directory.CreateDirectory(uploadsFolder);
                var uniqueFileName = Guid.NewGuid() + Path.GetExtension(imageFile.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }
                player.ImageUrl = "/uploads/players/" + uniqueFileName;
            }
            _playerRepository.Edit(player);
            await _playerRepository.CommitAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpGet]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Delete(int id)
        {
            var player = await _playerRepository.GetOneAsync(e => e.PlayerId == id, includes: [e => e.Team!]);
            if (player == null) return NotFound();
            return View(player);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var player = await _playerRepository.GetOneAsync(e => e.PlayerId == id);
            if (player == null) return NotFound();

            if (!string.IsNullOrEmpty(player.ImageUrl))
            {
                var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", player.ImageUrl.TrimStart('/'));
                if (System.IO.File.Exists(imagePath))
                    System.IO.File.Delete(imagePath);
            }
            _playerRepository.Delete(player);
            await _playerRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
