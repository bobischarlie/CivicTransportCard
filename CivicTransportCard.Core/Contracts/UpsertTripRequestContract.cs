namespace CivicTransportCard.Core.Contracts
{
    public class UpsertTripRequestContract
    {
        public string CardNo { get; set; }
        public Guid LocationId { get; set; }
    }
}
