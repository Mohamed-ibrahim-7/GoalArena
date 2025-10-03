using GoalArena.Data;
using GoalArena.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace GoalArena.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PaymentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // صفحة الدفع
        public IActionResult Pay(int ticketId)
        {
            var ticket = _context.Tickets
                .Include(t => t.Match)
                .ThenInclude(m => m.Stadium)
                .FirstOrDefault(t => t.TicketId == ticketId);

            if (ticket == null) return NotFound();

            return View(ticket);
        }

        // تنفيذ الدفع
        [HttpPost]
        public async Task<IActionResult> Pay(int ticketId, PaymentMethod method)
        {
            var user = await _userManager.GetUserAsync(User);
            var ticket = _context.Tickets.Include(t => t.Match).FirstOrDefault(t => t.TicketId == ticketId);

            if (ticket == null) return NotFound();

            var payment = new Payment
            {
                UserId = user.Id,
                Amount = ticket.Price,
                PaymentDate = DateTime.Now,
                Method = method,
                TransactionId = Guid.NewGuid().ToString() // مؤقتاً نولد رقم عشوائي
            };

            _context.payments.Add(payment);
            await _context.SaveChangesAsync();

            // ربط التذكرة بالدفع
            ticket.PaymentId = payment.Id;
            await _context.SaveChangesAsync();

            return RedirectToAction("MyTickets", "Ticket");
        }
    }
}