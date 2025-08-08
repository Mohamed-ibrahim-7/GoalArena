using GoalArena.DataAccess;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly ApplicationDbcontext _dbcontext;
        public TicketRepository(ApplicationDbcontext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
