using System.ComponentModel.DataAnnotations.Schema;

namespace CivicTransportCard.Core.Entities
{
    [Table("Location")]
    public class LocationEntity : BaseEntity
    {
        public string LocationName { get; set; }
        public string Description { get; set; }
    }
}
