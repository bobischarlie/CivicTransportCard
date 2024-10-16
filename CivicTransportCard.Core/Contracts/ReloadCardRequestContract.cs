using System.ComponentModel.DataAnnotations;

namespace CivicTransportCard.Core.Contracts
{
    public class ReloadCardRequestContract
    {
        [Range(100, 5000, ErrorMessage = "Load amount should be at least 100 and max of 5000.")]
        public decimal LoadAmount { get; set; }
        public string CardNo { get; set; }
    }
}
