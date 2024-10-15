namespace CivicTransportCard.Core.Contracts
{
    public class TransportCardRequestContract
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNo { get; set; }
        public bool IsSeniorOrPwd { get; set; }
        public string? IdNo { get; set; }
    }
}
