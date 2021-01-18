using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Waitlistme.Domain.Models;
using Waitlistme.Domain.Repositories;
using Waitlistme.Persistence.Contexts;

namespace Waitlistme.Persistence.Repositories
{
    public class PartyRepository : BaseRepository, IPartyRepository
    {
        public PartyRepository(WaitlistmeContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Party>> ListAsync()
        {
            return await _context.Parties.ToListAsync();
        }
    }
}