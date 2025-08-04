namespace GoalArena.Models
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public Match Match { get; set; }

        public int? PlayerId { get; set; }
        public Player? Player { get; set; }

        public int Minute { get; set; }
        public EventType EventType { get; set; }
        public string? Description { get; set; }
    }
    public enum EventType
    {
        Goal,
        Assist,
        YellowCard,
        RedCard,
        SubstitutionIn,
        SubstitutionOut,
        Injury,
        HalfTime,
        FullTime
    }
}
