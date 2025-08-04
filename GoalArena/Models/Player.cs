namespace GoalArena.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string NationalTeam { get; set; }
        public string Club { get; set; }
        public int Goals { get; set; }
        public int Assists { get; set; }            
        public int MatchesPlayed { get; set; }
        public double AverageRating { get; set; }
        public string ImageUrl { get; set; }


    }
}
