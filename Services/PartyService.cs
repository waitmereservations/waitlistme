using System.Collections.Generic;
using System.Threading.Tasks;
using Waitlistme.Domain.Models;
using Waitlistme.Domain.Services;
using Waitlistme.Domain.Repositories;

namespace Waitlistme.Services
{
    public class PartyService : IPartyService
    {
        private readonly IPartyRepository _partyRepository;

        public PartyService(IPartyRepository partyRepository)
        {
            this._partyRepository = partyRepository;
        }

        public async Task<IEnumerable<Party>> ListAsync()
        { 
            return await _partyRepository.ListAsync();
        }
    }
}