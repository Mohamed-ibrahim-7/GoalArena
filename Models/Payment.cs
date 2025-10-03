using GoalArena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public PaymentMethod Method { get; set; } // Cash, CreditCard, PayPal, Stripe

        public string TransactionId { get; set; } // رقم العملية (من بوابة الدفع)
        

        public ICollection<Ticket> Tickets { get; set; }
    }

    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        PayPal,
        Stripe
    }
    public enum PaymentStatus
    {
        Success,
        Pending
    }

}
