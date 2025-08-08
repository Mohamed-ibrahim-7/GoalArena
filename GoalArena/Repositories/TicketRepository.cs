using GoalArena.Data;

using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class TicketRepository : Repository<Ticket>, ITicketRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public TicketRepository(ApplicationDbContext context) : base(context)
        {
            _dbcontext = context;
        }
    }
}
