using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class SeasonRepository : Repository<Season>, ISeasonRepository

    {
        private readonly ApplicationDbcontext _dbcontext;
        public SeasonRepository(ApplicationDbcontext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
