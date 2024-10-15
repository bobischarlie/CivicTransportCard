using CivicTransportCard.Core.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace CivicTransportCard.Core.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid TransportCardId { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public Decimal Amount { get; set; }
        public Decimal EndingBalance { get; set; }
        public TransactionType TransactionTypeId { get; set; }
    }
}
