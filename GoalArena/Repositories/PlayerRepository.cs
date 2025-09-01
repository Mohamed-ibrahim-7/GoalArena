using GoalArena.Data;

using GoalArena.Models;

using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public PlayerRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;   
        }
    }
}
