namespace GoalArena.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Season> Seasons { get; set; }
    }
}
