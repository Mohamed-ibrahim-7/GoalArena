using GoalArena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoalArena.Models
{
    public class Team
    {                                                  // seed data   عدل علي الكنترول وضيف الداتا الا هضيفها في 
        public int Id { get; set; }

        // بيانات أساسية
        public string? Name { get; set; }                  
        public string? ShortName { get; set; }             
        public string? LogoUrl { get; set; }               
        public string Coach { get; set; } = null!;         

        // معلومات إضافية
        public DateTime? Founded { get; set; }            
        public string? City { get; set; }                 
        public string? Country { get; set; }              
        public string? Stadium { get; set; }              
        public int? StadiumCapacity { get; set; }         
        public string? Colors { get; set; }               
        public string? Website { get; set; }              

        //  إحصائيات تشبه جدول الدوري
        public int Played { get; set; }                   
        public int Wins { get; set; }                     
        public int Draws { get; set; }                    
        public int Losses { get; set; }                   
        public int GoalsFor { get; set; }                 
        public int GoalsAgainst { get; set; }             
        public int GoalDifference => GoalsFor - GoalsAgainst;
        public int Points => (Wins * 3) + (Draws);        
        public int Position { get; set; }                  

        // علاقات
        public int SeasonId { get; set; }
        public Season? Season { get; set; }

        public ICollection<Player>? Players { get; set; } 
        public ICollection<News>? News { get; set; }      
        public ICollection<TeamSeason>? TeamSeasons { get; set; }
        public ICollection<Match>? HomeMatches { get; set; }     
        public ICollection<Match>? AwayMatches { get; set; }     


    }
}
