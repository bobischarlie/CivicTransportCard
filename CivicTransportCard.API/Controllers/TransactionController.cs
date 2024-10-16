using CivicTransportCard.API.Services.Interface;
using CivicTransportCard.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CivicTransportCard.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;
        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("Trip")]
        public async Task<IActionResult> UpsertTripTransaction([FromBody]UpsertTripRequestContract upsertTripData)
        {
            try
            {
                var returnValue = await _transactionService.UpsertTransaction(upsertTripData);
                if (returnValue == null)
                {
                    return NotFound("Transaction not found or could not be processed.");
                }
                return Ok(returnValue);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while processing your request.");
            }
        }
    }
}