using CivicTransportCard.Core.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace CivicTransportCard.Core.Entities
{
    [Table("Transaction")]
    public class TransactionEntity : BaseEntity
    {
        public Guid TransportCardId { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public Decimal Amount { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public Decimal EndingBalance { get; set; }
        public TransactionType TransactionType { get; set; }

        public virtual List<TransactionLocationEntity> TransactionLocation { get; set; }
        public virtual TransportCardEntity TransportCard { get; set; }
    }
}
