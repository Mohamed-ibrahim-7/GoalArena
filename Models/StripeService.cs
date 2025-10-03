using Microsoft.Extensions.Configuration;
using Stripe.Checkout;

namespace GoalArena.Utility
{
    public class StripeService
    {
        private readonly IConfiguration _config;

        public StripeService(IConfiguration config)
        {
            _config = config;
            Stripe.StripeConfiguration.ApiKey = _config["Stripe:SecretKey"];
        }

        public Session CreateCheckoutSession(decimal amount, string successUrl, string cancelUrl)
        {
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> { "card" },
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        PriceData = new SessionLineItemPriceDataOptions
                        {
                            Currency = "usd", // أو "egp" لو مفعل
                            UnitAmount = (long)(amount * 100), // Stripe بيحسب بـ "cents"
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                                Name = "Match Ticket"
                            }
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = successUrl,
                CancelUrl = cancelUrl
            };

            var service = new SessionService();
            return service.Create(options);
        }
    }
}
