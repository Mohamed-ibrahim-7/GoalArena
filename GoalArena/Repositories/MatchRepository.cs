using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class MatchRepository : Repository<Match>, ImatchRepository 
    {
        private readonly ApplicationDbcontext _context;

        public MatchRepository(ApplicationDbcontext context) : base(context)
        {
            _context = context;
        }
    }
}
