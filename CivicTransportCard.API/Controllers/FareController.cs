using CivicTransportCard.API.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CivicTransportCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FareController : ControllerBase
    {
        private readonly IFareService _fareService;
        public FareController(IFareService fareService)
        {
            _fareService = fareService;
        }
        [HttpGet]
        public async Task<IActionResult> GetFares()
        {
            var fares = await _fareService.GetFaresAsync();
            return Ok(fares);
        }
    }
}
