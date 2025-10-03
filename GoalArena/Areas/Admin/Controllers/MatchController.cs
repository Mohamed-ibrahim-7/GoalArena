using GoalArena.Models;
using GoalArena.Repositories;
using GoalArena.Repositories.IRepositories;
using GoalArena.Utility;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IMatchEventRepository _matchEventRepository;
        private readonly ITicketRepository _ticketRepository;

        public MatchController(
            ImatchRepository matchRepository,
            ITeamRepository teamRepository,
            ISeasonRepository seasonRepository,
            ITournamentRepository tournamentRepository,
            IMatchEventRepository matchEventRepository,
            ITicketRepository ticketRepository)
        {
            _matchRepository = matchRepository;
            _teamRepository = teamRepository;
            _seasonRepository = seasonRepository;
            _tournamentRepository = tournamentRepository;
            _matchEventRepository = matchEventRepository;
            _ticketRepository = ticketRepository; // ✅ تمت الإضافة
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin},{SD.Company}")]
        public async Task<IActionResult> Index()
        {
            var matches = await _matchRepository.GetAsync(
                includes: [m => m.HomeTeam, m => m.AwayTeam, m => m.Season, m => m.Tournament, m => m.MatchEvents]);
            return View(matches);
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Details(int id)
        {
            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == id,
                includes: [
                    m => m.HomeTeam,
                    m => m.AwayTeam,
                    m => m.Season,
                    m => m.Tournament,
                    m => m.MatchEvents,
                    m => m.News,
                    m => m.Tickets
                ]);

            if (match == null) return NotFound();

            var matchEvents = await _matchEventRepository.GetAsync(
                filter: e => e.MatchId == id,
                includes: [
                    e => e.Player,
                    e => e.RelatedPlayer,
                    e => e.Team
                ]);

            if (matchEvents != null)
            {
                match.MatchEvents = matchEvents.ToList();
            }

            return View(match);
        }

        [HttpGet]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Create()
        {
            var teams = await _teamRepository.GetAsync();
            var seasons = await _seasonRepository.GetAsync();
            var tournaments = await _tournamentRepository.GetAsync();

            ViewBag.HomeTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.AwayTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Seasons = seasons.Select(s => new SelectListItem { Value = s.SeasonId.ToString(), Text = s.Name }).ToList();
            ViewBag.Tournaments = tournaments.Select(t => new SelectListItem { Value = t.TournamentId.ToString(), Text = t.Name }).ToList();

            ViewBag.MatchStatuses = Enum.GetValues(typeof(MatchStatus))
                .Cast<MatchStatus>()
                .Select(s => new SelectListItem { Value = ((int)s).ToString(), Text = s.ToString() })
                .ToList();

            ViewBag.MatchResults = Enum.GetValues(typeof(MatchResult))
                .Cast<MatchResult>()
                .Select(r => new SelectListItem { Value = ((int)r).ToString(), Text = r.ToString() })
                .ToList();

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

            return View(match);
        }

        [HttpGet]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit(int id)
        {
            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == id,
                includes: [m => m.HomeTeam, m => m.AwayTeam, m => m.Season, m => m.Tournament]);

            if (match == null) return NotFound();

            var teams = await _teamRepository.GetAsync();
            var seasons = await _seasonRepository.GetAsync();
            var tournaments = await _tournamentRepository.GetAsync();

            ViewBag.HomeTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.AwayTeams = teams.Select(t => new SelectListItem { Value = t.Id.ToString(), Text = t.Name }).ToList();
            ViewBag.Seasons = seasons.Select(s => new SelectListItem { Value = s.SeasonId.ToString(), Text = s.Name }).ToList();
            ViewBag.Tournaments = tournaments.Select(t => new SelectListItem { Value = t.TournamentId.ToString(), Text = t.Name }).ToList();

            ViewBag.MatchStatuses = Enum.GetValues(typeof(MatchStatus))
                .Cast<MatchStatus>()
                .Select(s => new SelectListItem { Value = ((int)s).ToString(), Text = s.ToString() })
                .ToList();

            ViewBag.MatchResults = Enum.GetValues(typeof(MatchResult))
                .Cast<MatchResult>()
                .Select(r => new SelectListItem { Value = ((int)r).ToString(), Text = r.ToString() })
                .ToList();

            return View(match);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Edit(int id, Match match)
        {
            if (id != match.MatchId) return NotFound();

            if (ModelState.IsValid)
            {
                _matchRepository.Edit(match);
                await _matchRepository.CommitAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(match);
        }

        [Authorize(Roles = $"{SD.SuperAdmin},{SD.Admin}")]
        public async Task<IActionResult> Delete(int id)
        {
            var match = await _matchRepository.GetOneAsync(
                m => m.MatchId == id,
                includes: [m => m.HomeTeam, m => m.AwayTeam]);

            if (match == null) return NotFound();

            _matchRepository.Delete(match);
            await _matchRepository.CommitAsync();
            return RedirectToAction(nameof(Index));
        }

      
        //  Ticket Booking & Payment
        
        [HttpPost]
        public async Task<IActionResult> BookTicket(int matchId, int quantity, [FromServices] StripeService stripeService)
        {
            var match = await _matchRepository.GetOneAsync(m => m.MatchId == matchId);
            if (match == null) return NotFound();

            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            var ticket = new Ticket
            {
                MatchId = matchId,
                UserId = userId,
                Quantity = quantity,
                Price = match.TicketPrice * quantity,
                PaymentStatus = "Pending"
            };

            await _ticketRepository.CreateAsync(ticket);
            await _ticketRepository.CommitAsync();

            // Stripe Checkout
            var session = stripeService.CreateCheckoutSession(
                ticket.Price,
                Url.Action("PaymentSuccess", "Match", new { id = ticket.TicketId }, Request.Scheme),
                Url.Action("PaymentCancel", "Match", new { id = ticket.TicketId }, Request.Scheme)
            );

            return Redirect(session.Url);
        }

        [HttpGet]
        public async Task<IActionResult> PaymentSuccess(int id)
        {
            var ticket = await _ticketRepository.GetOneAsync(t => t.TicketId == id);
            if (ticket == null) return NotFound();

            ticket.PaymentStatus = "Paid";
            _ticketRepository.Edit(ticket);
            await _ticketRepository.CommitAsync();

            TempData["Success"] = "✅ تم دفع التذكرة بنجاح!";
            return RedirectToAction("Details", new { id = ticket.MatchId });
        }

        [HttpGet]
        public async Task<IActionResult> PaymentCancel(int id)
        {
            var ticket = await _ticketRepository.GetOneAsync(t => t.TicketId == id);
            if (ticket == null) return NotFound();

            ticket.PaymentStatus = "Cancelled";
            _ticketRepository.Edit(ticket);
            await _ticketRepository.CommitAsync();

            TempData["Error"] = "❌ تم إلغاء عملية الدفع!";
            return RedirectToAction("Details", new { id = ticket.MatchId });
        }
    }
}
