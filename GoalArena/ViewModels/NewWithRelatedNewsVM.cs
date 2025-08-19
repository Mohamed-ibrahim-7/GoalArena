using GoalArena.Areas.Customer.Controllers;

namespace GoalArena.ViewModels
{
    public class NewWithRelatedNewsVM
    {
        public News News { get; set; }
        public List<News> RelatedNews { get; set; } = new List<News>();
    }
}
