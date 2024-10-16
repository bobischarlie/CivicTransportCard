using CivicTransportCard.API.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CivicTransportCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }
        [HttpGet()]
        public async Task<IActionResult> GetLocationsAsync()
        {
            try
            {
                var locations = await _locationService.GetLocationsAsync();
                return Ok(locations);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
