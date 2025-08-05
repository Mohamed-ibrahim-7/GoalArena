namespace Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }     = string.Empty;
        public string Position { get; set; }   = string.Empty;
        public int Age { get; set; }
        public string NationalTeam { get; set; }   = string.Empty;
        public string Club { get; set; }     = string.Empty;
        public int Goals { get; set; }
        public int Assists { get; set; }            
        public int MatchesPlayed { get; set; }
        public double AverageRating { get; set; }
        public string ImageUrl { get; set; }     = string.Empty;


    }
}
