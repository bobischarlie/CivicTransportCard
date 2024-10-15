using Microsoft.AspNetCore.Mvc;

namespace CivicTransportCard.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> CreateTransaction()
        {
            return Ok();
        }

    }
}
