namespace CivicTransportCard.Core.Models
{
    public class TransportCard
    {
        public  Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string CardNo { get; set; }
        public  decimal Balance { get; set; }
        public bool IsSeniorOrPwd { get; set; }
        public string IdNo { get; set; }
    }
}
