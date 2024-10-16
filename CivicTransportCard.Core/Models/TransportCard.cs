using CivicTransportCard.Core.Enum;

namespace CivicTransportCard.Core.Models
{
    public class TransportCard
    {
        public  Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string CardNo { get; set; }
        public  decimal Balance { get; set; }
        public CardType CardType { get; set; }
        public string IdNo { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public DateTime DateExpire { get; set; }
    }
}
