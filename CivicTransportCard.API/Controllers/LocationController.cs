using CivicTransportCard.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace CivicTransportCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetLocationsAsync()
        {
            var locations = new List<Location>();
            return Ok(locations);
        }
    }
}
