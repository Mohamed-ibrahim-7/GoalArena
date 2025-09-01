
using GoalArena.Models;

namespace GoalArena.Models
    {
        public class MatchEvent
        {
            public int Id { get; set; }

            public int MatchId { get; set; }
            public Match Match { get; set; } = null!;

            // الفريق صاحب الحدث
            public int TeamId { get; set; }
            public Team Team { get; set; } = null!;

            // اللاعب الأساسي في الحدث
            public int? PlayerId { get; set; }
            public Player? Player { get; set; }

            // لاعب إضافي (مساعد الهدف أو المستبدل)
            public int? RelatedPlayerId { get; set; }
            public Player? RelatedPlayer { get; set; }

            // تفاصيل زمنية
            public int Minute { get; set; }              
            public int? ExtraMinute { get; set; }        

            
            public EventType EventType { get; set; }
            public GoalType? GoalType { get; set; }      

            // وصف إضافي
            public string? Description { get; set; }

            
            public int? Shots { get; set; }             
            public int? ShotsOnTarget { get; set; }     
            public int? Possession { get; set; }        
            public int? PassAccuracy { get; set; }      
            public int? Fouls { get; set; }             
            public int? Corners { get; set; }           
            public int? Offsides { get; set; }          
            public int? YellowCards { get; set; }       
            public int? RedCards { get; set; }          
            public int? Saves { get; set; }             
        }

        public enum EventType
        {
            Goal,
            Assist,
            YellowCard,
            RedCard,
            Substitution,
            Injury,
            Offside,
            StartFirstHalf,
            EndFirstHalf,
            StartSecondHalf,
            EndSecondHalf,
            ExtraTime,
            PenaltyShootout,
            MatchStatistic // نوع مخصص للإحصائيات
        }

        public enum GoalType
        {
            Normal,         // هدف عادي
            Penalty,        // ركلة جزاء
            FreeKick,       // ركلة حرة مباشرة
            OwnGoal,        // هدف عكسي
            Header          // بالرأس
        }
    }


