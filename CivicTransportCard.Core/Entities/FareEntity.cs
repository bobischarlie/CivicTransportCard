using System.ComponentModel.DataAnnotations.Schema;

namespace CivicTransportCard.Core.Entities
{
    [Table("Fare")]
    public class FareEntity : BaseEntity
    {
        [Column(TypeName = "decimal(7,2)")]
        public decimal FareAmount { get; set; }

        public Guid EntryPointLocationId { get; set; }

        public Guid ExitPointLocationId { get; set; }

        public LocationEntity EntryPointLocation { get; set; }
        public LocationEntity ExitPointLocation { get; set; }
    }
}
