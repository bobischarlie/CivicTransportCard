using CivicTransportCard.Core.Entities;

namespace CivicTransportCard.Core.Models
{
    public class Fare
    {
        public decimal FareAmount { get; set; }
        public Location EntryPointLocation { get; set; }
        public Location ExitPointLocation { get; set; }
    }
}
