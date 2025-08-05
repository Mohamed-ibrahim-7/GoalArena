namespace GoalArena.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public int MatchId { get; set; }
        public Match Match { get; set; }      = null!;

        public string UserId { get; set; }    = null!;
        public string SeatNumber { get; set; }     = null!;
        public string TicketStatus { get; set; } = null!; 

        public decimal Price { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}
       public enum TicketStatus
    {
    Available,
    Pending,
    reserved,
    Sold,
    Cancelled
     }