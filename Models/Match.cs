namespace GoalArena.Models
{
    public class Match
    {
        public int MatchId { get; set; }

        public int HomeTeamId { get; set; }
        public Team? HomeTeam { get; set; }

        public int AwayTeamId { get; set; }
        public Team? AwayTeam { get; set; }

        public DateTime MatchDate { get; set; }
        public string? Stadium { get; set; }

        public MatchResult? Result { get; set; }   

        public MatchStatus Status { get; set; } = MatchStatus.Scheduled;

        public int SeasonId { get; set; }
        public Season? Season { get; set; }

        public int TournamentId { get; set; }
        public Tournament? Tournament { get; set; }

        public ICollection<MatchEvent>? MatchEvents { get; set; }
        public ICollection<News>? News { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
    }

    public enum MatchStatus
    {
        Scheduled,    
        InProgress,   
        Completed,    
        Cancelled     
    }

    public enum MatchResult
    {
        HomeWin,
        AwayWin,
        Draw
    }

}
