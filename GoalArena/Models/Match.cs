namespace GoalArena.Models
{
    public class Match
    {
       
        
            public int Id { get; set; }

            public int HomeTeamId { get; set; }
            public Team HomeTeam { get; set; }

            public int AwayTeamId { get; set; }
            public Team AwayTeam { get; set; }

            public DateTime MatchDate { get; set; }
            public string Stadium { get; set; }
            public string? Result { get; set; }

            public int SeasonId { get; set; }
            public Season Season { get; set; }   

            public ICollection<MatchEvent> MatchEvents { get; set; }
        

    }
}
