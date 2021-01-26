using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Waitlistme.Domain.Models;
using Waitlistme.Domain.Services;
using Waitlistme.Resources;

namespace Waitlistme.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class PartyController : Controller
    {

        private readonly IPartyService _partyService;
		private readonly IMapper _mapper;

		public PartyController(IPartyService partyService, IMapper mapper)
        {
            _partyService = partyService;   
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<PartyReadDto>> GetAllParties()
        {
            var parties = _partyService.ListParty();
            return Ok(_mapper.Map<PartyReadDto>(parties));
        }
    }
}