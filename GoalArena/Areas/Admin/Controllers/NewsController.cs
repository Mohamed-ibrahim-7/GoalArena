using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using GoalArena.Utility;
using GoalArena.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Threading.Tasks;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly InewsRepository _newsRepository;
        private readonly IPlayerRepository _playerRepository;
        private readonly ITeamRepository _teamRepository;
        private readonly ImatchRepository _matchRepository;

        public NewsController(InewsRepository newsRepository , IPlayerRepository playerRepository , ITeamRepository teamRepository , ImatchRepository matchRepository)
        {
            _newsRepository = newsRepository;
            _matchRepository = matchRepository;
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;
        }
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin},{SD.Company}")]
        public async Task<IActionResult> Index()
        {
            var news = await _newsRepository.GetAsync(includes: [e =>e.Match , e =>e.Player , e=>e.Team]);
            return View(news);
        }

        [HttpGet]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Create()
        {
            var players = await _playerRepository.GetAsync();
            var teams = await _teamRepository.GetAsync();
            var matches = await _matchRepository.GetAsync();
            MatchWithPlayerWithTeamVM  matchWithPlayerWithTeamVM=new()
            {
                Players = players.Select(e => new SelectListItem()
                {
                    Text = e.Name,
                    Value = e.PlayerId.ToString()
                }).ToList(),
                Teams = teams.Select(e => new SelectListItem()
                {
                    Text = e.Name,
                    Value = e.Id.ToString()
                }).ToList(),
                Matches = matches.Select(e => new SelectListItem()
                {
                    Text = e.MatchDate.ToString("yyyy-MM-dd"),
                    Value = e.MatchId.ToString()
                }).ToList(),
                News= new()
            };
            return View(matchWithPlayerWithTeamVM);
        }

        [HttpPost]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Create(News news,IFormFile imageUrl)
        {
            if (!ModelState.IsValid)
            {
                var players = await _playerRepository.GetAsync();
                var teams = await _teamRepository.GetAsync();
                var matches = await _matchRepository.GetAsync();
                MatchWithPlayerWithTeamVM matchWithPlayerWithTeamVM = new()
                {
                    Players = players.Select(e => new SelectListItem()
                    {
                        Text = e.Name,
                        Value = e.PlayerId.ToString()
                    }).ToList(),
                    Teams = teams.Select(e => new SelectListItem()
                    {
                        Text = e.Name,
                        Value = e.Id.ToString()
                    }).ToList(),
                    Matches = matches.Select(e => new SelectListItem()
                    {
                        Text = e.MatchDate.ToString("yyyy-MM-dd"),
                        Value = e.MatchId.ToString()
                    }).ToList(),
                    News = new()
                };
                return View(matchWithPlayerWithTeamVM);
            }
          if (imageUrl is not null && imageUrl.Length > 0)
          {
              var fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageUrl.FileName);
              var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images", fileName);
          
              // Save img in wwwroot
              using (var stream = System.IO.File.Create(filePath))
              {
                  imageUrl.CopyTo(stream);
              }

                // Save img in DB
                news.ImageNews = fileName;
          
              // Save product in DB
              await _newsRepository.CreateAsync(news);
              await _matchRepository.CommitAsync();
          
              return RedirectToAction(nameof(Index));
          }
            return BadRequest();

        }

        [HttpGet]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit([FromRoute] int id)
        {
            var news = await _newsRepository.GetOneAsync(e => e.Id == id);
            if (news is not null)
            {

                var players = await _playerRepository.GetAsync();
                var teams = await _teamRepository.GetAsync();
                var matches = await _matchRepository.GetAsync();
                MatchWithPlayerWithTeamVM matchWithPlayerWithTeamVM = new()
                {
                    Players = players.Select(e => new SelectListItem()
                    {
                        Text = e.Name,
                        Value = e.PlayerId.ToString()
                    }).ToList(),
                    Teams = teams.Select(e => new SelectListItem()
                    {
                        Text = e.Name,
                        Value = e.Id.ToString()
                    }).ToList(),
                    Matches = matches.Select(e => new SelectListItem()
                    {
                        Text = e.MatchDate.ToString("yyyy-MM-dd"),
                        Value = e.MatchId.ToString()
                    }).ToList(),
                    News = new()
                };

                return View(matchWithPlayerWithTeamVM);
            }
            return RedirectToAction("NotFoundPage", "Home");

        }

        [HttpPost]
       
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit(News news)
        {
            var newsInDB = await _newsRepository.GetOneAsync(e => e.Id == news.Id, tracked: false);
            if (newsInDB is not null)
            {
                if (!ModelState.IsValid)
                {
                    var players = await _playerRepository.GetAsync();
                    var teams = await _teamRepository.GetAsync();
                    var matches = await _matchRepository.GetAsync();
                    MatchWithPlayerWithTeamVM matchWithPlayerWithTeamVM = new()
                    {
                        Players = players.Select(e => new SelectListItem()
                        {
                            Text = e.Name,
                            Value = e.PlayerId.ToString()
                        }).ToList(),
                        Teams = teams.Select(e => new SelectListItem()
                        {
                            Text = e.Name,
                            Value = e.Id.ToString()
                        }).ToList(),
                        Matches = matches.Select(e => new SelectListItem()
                        {
                            Text = e.MatchDate.ToString("yyyy-MM-dd"),
                            Value = e.MatchId.ToString()
                        }).ToList(),
                        News = new()
                    };

                    return View(matchWithPlayerWithTeamVM);
                }
            }
            return NotFound();
        }
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var news = await _newsRepository.GetOneAsync(e => e.Id == id);

            if (news is not null)
            {
                
                _newsRepository.Delete(news);
                await _matchRepository.CommitAsync();

                return RedirectToAction(nameof(Index));
            }

            return RedirectToAction("NotFoundPage", "Home");
        }
    }
}
