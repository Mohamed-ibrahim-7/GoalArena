namespace GoalArena.Models
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<Match> Matches { get; set; }
    }
}
