using GoalArena.Models;

namespace GoalArena.Models
{
    public class Match
    {
        public int MatchId { get; set; }          // seed data   عدل علي الكنترول وضيف الداتا الا هضيفها في 

        // الفرق
        public int HomeTeamId { get; set; }
        public Team? HomeTeam { get; set; }

        public int AwayTeamId { get; set; }
        public Team? AwayTeam { get; set; }

        // بيانات عامة عن المباراة
        public DateTime MatchDate { get; set; }            // تاريخ المباراة
        public TimeSpan? KickOffTime { get; set; }         // وقت البداية
        public string? Stadium { get; set; }               // الاستاد
      
        public string? Round { get; set; }                 // الجولة (مثلاً: الجولة 5)

        // النتيجة والتفاصيل
        public int? HomeScore { get; set; }                // أهداف الفريق المضيف
        public int? AwayScore { get; set; }                // أهداف الفريق الضيف
        public int? HomePenaltyScore { get; set; }         // ركلات الترجيح (إن وجدت)
        public int? AwayPenaltyScore { get; set; }
        public MatchResult? Result { get; set; }           // فوز/تعادل/خسارة
        public MatchStatus Status { get; set; } = MatchStatus.Scheduled;

       
        public DateTime? EndTime { get; set; }             // وقت انتهاء المباراة

        // علاقات
        public int SeasonId { get; set; }
        public Season? Season { get; set; }

        public int TournamentId { get; set; }
        public Tournament? Tournament { get; set; }

        public ICollection<MatchEvent>? MatchEvents { get; set; }  // الأهداف، الكروت، التبديلات
        public ICollection<News>? News { get; set; }
        public decimal TicketPrice { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }
    }

    public enum MatchStatus
    {
        Scheduled,    
        InProgress,  
        HalfTime,     
        ExtraTime,  
        Penalties,    
        Completed,    
        Postponed,    
        Cancelled     
    }

    public enum MatchResult
    {
        HomeWin,
        AwayWin,
        Draw,
        Pending   
    }

}
