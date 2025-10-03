using GoalArena.Data;
using GoalArena.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoalArena.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TicketController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // حجز تذكرة
        [HttpPost]
        public async Task<IActionResult> BookTicket(int matchId, string seatNumber)
        {
            var user = await _userManager.GetUserAsync(User);
            var match = _context.Matches.Find(matchId);

            if (match == null) return NotFound();

            var ticket = new Ticket
            {
                MatchId = matchId,
                SeatNumber = seatNumber,
                Price = match.TicketPrice,
                UserId = user.Id
            };

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            return RedirectToAction("Pay", "Payment", new { ticketId = ticket.TicketId });
        }

        // تذاكري
        public async Task<IActionResult> MyTickets()
        {
            var user = await _userManager.GetUserAsync(User);
            var tickets = _context.Tickets
                                  .Include(t => t.Match)
                                  .ThenInclude(m => m.Stadium)
                                  .Include(t => t.Payment)
                                  .Where(t => t.UserId == user.Id)
                                  .ToList();

            return View(tickets);
        }
    }

}
