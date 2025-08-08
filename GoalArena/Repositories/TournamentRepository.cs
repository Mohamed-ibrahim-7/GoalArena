using GoalArena.Data;

using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class TournamentRepository : Repository<Tournament>, ITournamentRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public TournamentRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
