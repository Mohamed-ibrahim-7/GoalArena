
   
        namespace GoalArena.Models
        {  

            public class Player
        {
            public int PlayerId { get; set; }

            // معلومات أساسية
            public string Name { get; set; } = string.Empty;        // اسم اللاعب
            public string FullName { get; set; } = string.Empty;    // الاسم الكامل
            public string Position { get; set; } = string.Empty;    // المركز الأساسي (مثلاً: مهاجم)
            public string? SecondaryPosition { get; set; }          // مركز ثانوي (مثلاً: جناح أيمن)

            // بيانات شخصية
            public DateTime? DateOfBirth { get; set; }              // تاريخ الميلاد
            public int Age { get; set; }                            // العمر
            public string Nationality { get; set; } = string.Empty; // الجنسية
            public string NationalTeam { get; set; } = string.Empty;// المنتخب الذي يمثله
            public int? ShirtNumber { get; set; }                   // رقم القميص
            

           
            public int TeamId { get; set; }
            public Team? Team { get; set; }

            
            public string ImageUrl { get; set; } = string.Empty;

         
            public int MatchesPlayed { get; set; }
            public int Goals { get; set; }
            public int Assists { get; set; }
            public int YellowCards { get; set; }
            public int RedCards { get; set; }
            public int MinutesPlayed { get; set; }                  

   
        }
    }



