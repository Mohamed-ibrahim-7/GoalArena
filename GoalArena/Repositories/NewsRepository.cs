using GoalArena.Data;

using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class NewsRepository : Repository<News>, InewsRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public NewsRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
