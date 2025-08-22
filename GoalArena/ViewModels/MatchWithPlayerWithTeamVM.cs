using GoalArena.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GoalArena.ViewModels
{
    public class MatchWithPlayerWithTeamVM
    {
        public List<SelectListItem> Players { get; set; } = null!;
        public List<SelectListItem> Teams { get; set; } = null!;
        public List<SelectListItem> Matches { get; set; } = null!;
        public News? News { get; set; }


    }
}
