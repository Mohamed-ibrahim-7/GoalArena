using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        private readonly ApplicationDbcontext _dbcontext;
        public PlayerRepository(ApplicationDbcontext context) : base(context)
        {
            _dbcontext = context;   
        }
    }
}
