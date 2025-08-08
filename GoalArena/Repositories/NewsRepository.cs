using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class NewsRepository : Repository<News>, InewsRepository
    {
        private readonly ApplicationDbcontext _dbcontext;
        public NewsRepository(ApplicationDbcontext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
