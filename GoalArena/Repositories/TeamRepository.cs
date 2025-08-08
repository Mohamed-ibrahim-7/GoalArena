using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class TeamRepository : Repository<Team>, iTeamRepository
    {
        private readonly ApplicationDbcontext _dbcontext;
        public TeamRepository(ApplicationDbcontext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
