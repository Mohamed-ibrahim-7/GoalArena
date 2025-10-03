using GoalArena.Data;
using GoalArena.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoalArena.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }

        // صفحة الحجز
        [HttpGet]
        public IActionResult BookTicket(int matchId)
        {
            var ticket = new Ticket { MatchId = matchId, Quantity = 1 };
            return View(ticket);
        }

        // تنفيذ الحجز وتحويل للدفع
        [HttpPost]
        public IActionResult BookTicket(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                _context.Tickets.Add(ticket);
                _context.SaveChanges();

                // بعد الحجز روح لصفحة الدفع
                return RedirectToAction("Checkout", "Payment", new { area = "Customer", ticketId = ticket.TicketId });
            }

            return View(ticket);
        }
    }
}
