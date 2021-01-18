using Waitlistme.Persistence.Contexts;

namespace Waitlistme.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly WaitlistmeContext _context;

        public BaseRepository(WaitlistmeContext context)
        {
            _context = context;
        }
    }
}