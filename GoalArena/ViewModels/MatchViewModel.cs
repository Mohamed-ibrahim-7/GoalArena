namespace GoalArena.ViewModels
{
    public class MatchViewModel
    {
        public string Team1Name { get; set; }   = string.Empty;

        public string Team1Flag { get; set; }    = string.Empty;
        public int Team1Score { get; set; }

        public string Team2Name { get; set; }= string.Empty;
        public string Team2Flag { get; set; } = string.Empty;
        public int Team2Score { get; set; }

        public string Status { get; set; } = string.Empty; // انتهت - مباشر - قريباً
        public string DayCategory { get; set; } = string.Empty; // today - yesterday - tomorrow

    
        public bool IsFinished { get; set; } // هل انتهت المباراة
        public string ?BestPlayer { get; set; } // أفضل لاعب (يحدد بعد انتهاء المباراة)
    }
}
