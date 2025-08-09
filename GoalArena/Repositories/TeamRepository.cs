
using GoalArena.Data;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class TeamRepository : Repository<Team>, iTeamRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public TeamRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
