using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CivicTransportCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportCardController : ControllerBase
    {
        private readonly ITransportCardService _transportCardService;
        public TransportCardController(ITransportCardService transportCardService)
        {
            _transportCardService = transportCardService;
        }

        [HttpPost()]
        public async Task<IActionResult> RegisterTransportCard(TransportCardRequestContract transportCardRequest)
        {
            var result = await _transportCardService.AddNewTransportCardAsync(transportCardRequest);
            return Ok(result);
        }
    }
}
