using GoalArena.Models;
using GoalArena.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace GoalArena.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NewsController : Controller
    {
        private readonly InewsRepository _newsRepository;

        public NewsController(InewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }

        public async Task<IActionResult> Index()
        {
            var newsList = await _newsRepository.GetAsync();
            return View(newsList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(News news)
        {
            if (!ModelState.IsValid)
                return View(news);

            await _newsRepository.CreateAsync(news);
            await _newsRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit([FromRoute] int id)
        {
            var newsItem = await _newsRepository.GetOneAsync(e => e.Id == id);
            if (newsItem == null)
                return NotFound();

            return View(newsItem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(News news)
        {
            if (!ModelState.IsValid)
                return View(news);

            _newsRepository.Edit(news);
            await _newsRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var newsItem = await _newsRepository.GetOneAsync(e => e.Id == id);
            if (newsItem == null)
                return NotFound();

            _newsRepository.Delete(newsItem);
            await _newsRepository.CommitAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
