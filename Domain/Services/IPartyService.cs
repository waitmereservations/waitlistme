using System.Collections.Generic;
using System.Threading.Tasks;
using Waitlistme.Domain.Models;

namespace Waitlistme.Domain.Services
{
    public interface IPartyService
    {
         Task<IEnumerable<Party>> ListParty();
    }
}