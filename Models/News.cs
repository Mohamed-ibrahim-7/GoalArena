namespace GoalArena.Models
{
    public class News
    {   public int Id { get; set; }
        public string? Title{ get; set; }
        public string ?Content { get; set; }
        public DateTime PublishedDate { get; set; } 
        public int playerId { get; set; }   
        public Player? Player { get; set; }
        public int TeamId { get; set; }
        public Team? Team { get; set; }
        public int MatchId { get; set; }
        public Match? Match { get; set; }
        public string? ImageNews { get; set; } =string.Empty;


    }
}
