using CivicTransportCard.API.Services.Interface;
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
        [HttpPost("/Trip")]
        public async Task<IActionResult> UpsertTripTransaction(string cardNo, Guid locationId)
        {
            var returnValue = await _transactionService.UpsertTransaction(cardNo, locationId);
            return Ok(returnValue);
        }
    }
}