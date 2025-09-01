namespace GoalArena.Models
{
    public class TeamSeason
    {
        public int Id { get; set; }

        // علاقات
        public int TeamId { get; set; }
        public Team? Team { get; set; }

        public int SeasonId { get; set; }
        public Season? Season { get; set; }

        //  إحصائيات الدوري
        public int Played { get; set; }                // المباريات الملعوبة
        public int Wins { get; set; }                  // الفوز
        public int Draws { get; set; }                 // التعادل
        public int Losses { get; set; }                // الخسارة

        public int GoalsFor { get; set; }              // أهداف مسجلة
        public int GoalsAgainst { get; set; }          // أهداف مستقبلة
        public int GoalDifference => GoalsFor - GoalsAgainst; // فارق الأهداف

        public int Points { get; set; }                // النقاط
        public int Rank { get; set; }                  // الترتيب في الجدول

       
        public string? Form { get; set; }              // آخر 5 مباريات (W-D-L)
        public bool IsQualified { get; set; }          // مؤهل لبطولة قارية
        public bool IsRelegated { get; set; }          // مهدد بالهبوط
    }
}
