using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waitlistme.Domain.Models;
using Waitlistme.Domain.Services;

namespace Waitlistme.Controllers
{
    [Route("/api/[controller]")]
    public class PartyController : Controller
    {

        private readonly IPartyService _partyService;
        
        public PartyController(IPartyService partyService)
        {
            _partyService = partyService;   
        }

        [HttpGet]
        public async Task<IEnumerable<Party>> GetAllAsync()
        {
            var parties = await _partyService.ListAsync();
            return parties;
        }
    }
}