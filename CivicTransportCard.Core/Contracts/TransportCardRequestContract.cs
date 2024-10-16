using CivicTransportCard.Core.Enum;

namespace CivicTransportCard.Core.Contracts
{
    public class TransportCardRequestContract
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNo { get; set; }
        public CardType CardType { get; set; }
        public string? IdNo { get; set; }
    }
}
