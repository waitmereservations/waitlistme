using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waitlistme.Domain.Models;
using Waitlistme.Domain.Services;

namespace Waitlistme.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PartyController : Controller
    {

        private readonly IPartyService _partyService;
        
        public PartyController(IPartyService partyService)
        {
            _partyService = partyService;   
        }

        [HttpGet]
        public ActionResult <IEnumerable<Party>> GetAllAsync()
        {
            var parties = _partyService.ListAsync();
            return Ok(parties);
        }
    }
}