using GoalArena.Data;

using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class SeasonRepository : Repository<Season>, ISeasonRepository

    {
        private readonly ApplicationDbContext _dbcontext;
        public SeasonRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
