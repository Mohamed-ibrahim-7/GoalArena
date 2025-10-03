using GoalArena.Data;
using GoalArena.Models;
using Microsoft.AspNetCore.Mvc;
using Stripe.Checkout;

namespace GoalArena.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Checkout(int ticketId)
        {
            var ticket = _context.Tickets
                .Where(t => t.TicketId == ticketId)
                .FirstOrDefault();

            if (ticket == null) return NotFound();

            var domain = "https://localhost:7291/";

            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            UnitAmount = (long)(ticket.Price * 100), // السعر بالسنت
                            Currency = "usd",
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "Match Ticket"
                            }
                        },
                        Quantity = ticket.Quantity
                    }
                },
                Mode = "payment",
                SuccessUrl = domain + "Customer/Payment/Success",
                CancelUrl = domain + "Customer/Payment/Cancel"
            };

            var service = new SessionService();
            Session session = service.Create(options);
            Response.Headers.Add("Location", session.Url);

            return new StatusCodeResult(303);
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Cancel()
        {
            return View();
        }
    }
}
