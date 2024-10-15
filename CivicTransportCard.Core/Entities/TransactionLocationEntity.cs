using System.ComponentModel.DataAnnotations.Schema;

namespace CivicTransportCard.Core.Entities
{
    [Table("TransactionLocation")]
    public class TransactionLocationEntity : BaseEntity
    {
        public Guid TransactionId { get; set; }
        public Guid EntryPointLocationId { get; set; }
        public Guid ExitPointLocationId { get; set; }

        public TransactionEntity Transaction { get; set; }
        public LocationEntity EntryPointLocation { get; set; }
        public LocationEntity ExitPointLocation { get; set; }
    }
}
