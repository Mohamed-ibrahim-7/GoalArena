namespace GoalArena.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }     = string.Empty;
        public string Position { get; set; }   = string.Empty;
        public int Age { get; set; }
        public string NationalTeam { get; set; }   = string.Empty;
        public int TeamId { get; set; }
        public Team? Team { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }            
        public int MatchesPlayed { get; set; }
        public string ImageUrl { get; set; }     = string.Empty;


    }
}
