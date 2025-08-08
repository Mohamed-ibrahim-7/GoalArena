using GoalArena.Data;

using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class MatchRepository : Repository<Match>, ImatchRepository 
    {
        private readonly ApplicationDbContext _context;

        public MatchRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
