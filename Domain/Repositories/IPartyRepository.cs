using System.Collections.Generic;
using System.Threading.Tasks;
using Waitlistme.Domain.Models;

namespace Waitlistme.Domain.Repositories
{
    public interface IPartyRepository
    {
         Task<IEnumerable<Party>> ListAsync();
    }
}