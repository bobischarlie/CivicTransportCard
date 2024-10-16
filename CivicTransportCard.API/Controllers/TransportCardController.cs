using CivicTransportCard.API.Services;
using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Contracts;
using CivicTransportCard.Core.Models;
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

        [HttpPut("ReloadCard")]
        public async Task<IActionResult> ReloadTransportCard([FromBody] ReloadCardRequestContract reloadCardRequest)
        {
            try
            {
                var transportCard = await _transportCardService.ReloadCardAsync(reloadCardRequest);
                if (transportCard == null)
                {
                    return NotFound("Transaction not found or could not be processed.");
                }
                return Ok(transportCard);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
