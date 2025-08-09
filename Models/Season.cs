namespace GoalArena.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public string Name { get; set; }     = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SeasonStatus Status { get; set; }

        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }       = null!;

        public ICollection<Team> Teams { get; set; }     = new List<Team>();
        public ICollection<Match> Matches { get; set; }   = new List<Match>();
    }
}
public enum SeasonStatus
{
    Upcoming,
    Ongoing,
    Completed,
    Cancelled
}