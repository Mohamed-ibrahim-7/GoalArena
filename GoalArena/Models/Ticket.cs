namespace GoalArena.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int MatchId { get; set; }
        public Match Match { get; set; }

        public string UserId { get; set; }     
        public string SeatNumber { get; set; }
        public string Status { get; set; }     // Pending / Paid / Cancelled

        public string? PaymentInfo { get; set; } // رقم عملية الدفع / sessionId من Stripe
    }
}
