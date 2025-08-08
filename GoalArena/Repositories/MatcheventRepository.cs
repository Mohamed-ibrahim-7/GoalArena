using GoalArena.Data;

using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class MatcheventRepository : Repository<MatchEvent>, IMatchEventRepository

    {
        private readonly ApplicationDbContext _dbcontext;
        public MatcheventRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext= context;
        }
    }
}
