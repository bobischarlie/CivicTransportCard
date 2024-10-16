using Microsoft.AspNetCore.Mvc;

namespace CivicTransportCard.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpPost("/Trip")]
        public async Task<IActionResult> UpsertTripTransaction()
        {
            return Ok();
        }

    }
}