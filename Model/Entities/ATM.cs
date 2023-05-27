namespace ATMSimulator.Model.Entities
{
    public class ATM : BaseEntity
    {
        public string Location { get; set; }
        public bool IsOnline { get; set; }
        public decimal CashBalance { get; set; }
        public decimal MaxWithdrawalLimit { get; set; }
    }
}
