using GoalArena.Data;
using GoalArena.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoalArena.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TicketController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // ✅ عرض صفحة الحجز
        [HttpGet]
        public async Task<IActionResult> BookTicket(int matchId)
        {
            var match = await _context.Matches
                .FirstOrDefaultAsync(m => m.MatchId == matchId);

            if (match == null) return NotFound();

            return View(match);
        }

        // ✅ تأكيد الحجز
        [HttpPost]
        public async Task<IActionResult> BookTicketConfirmed(int matchId, int quantity)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();

            var match = await _context.Matches.FindAsync(matchId);
            if (match == null) return NotFound();

            var ticket = new Ticket
            {
                MatchId = matchId,
                UserId = user.Id,
                Quantity = quantity,
                Price = match.TicketPrice * quantity,
                PurchaseDate = DateTime.UtcNow,
                PaymentStatus = "Pending"
                ,
                TicketStatus = "Pending"

            };

            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();

            // بعد الحجز يروح لصفحة الدفع
            return RedirectToAction("Checkout", "Payment", new { area = "Customer", ticketId = ticket.TicketId });
        }
    }
}
