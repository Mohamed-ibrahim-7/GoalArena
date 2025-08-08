using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class MatcheventRepository : Repository<MatchEvent>, IMatchEventRepository

    {
        private readonly  ApplicationDbcontext _dbcontext;
        public MatcheventRepository(ApplicationDbcontext context) : base(context)
        {
            _dbcontext= context;
        }
    }
}
