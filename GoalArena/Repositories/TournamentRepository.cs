using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class TournamentRepository : Repository<Tournament>, ITournamentRepository
    {
        private readonly ApplicationDbcontext _dbcontext;
        public TournamentRepository(ApplicationDbcontext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
