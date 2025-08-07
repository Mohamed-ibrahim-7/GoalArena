namespace GoalArena.Models
{
    public class Tournament
    {
        public int TournamentId { get; set; }
        public string Name { get; set; }   = string.Empty;
        public string Country { get; set; }     = null!;
        public string LogoUrl { get; set; } = string.Empty; 


        public ICollection<Season> Seasons { get; set; }      = new List<Season>();
        public ICollection<Match> Matches { get; set; }  = new List<Match>();
    }
}
