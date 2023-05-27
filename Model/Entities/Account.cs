using ATMSimulator.Model.Enum;

namespace ATMSimulator.Model.Entities
{
    public class Account : BaseEntity
    {
        public string Number { get; set; }
        public AccountType AccountType { get; set; }
        public Guid CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}
