using GoalArena.Data;
using GoalArena.Models;
using GoalArena.Repositories.IRepositories;

namespace GoalArena.Repositories
{
    public class UserOTPRepository : Repository<UserOTP>, IUserOTPRepository
    {
        private readonly ApplicationDbContext _context;

        public UserOTPRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
