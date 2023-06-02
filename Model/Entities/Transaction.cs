using ATMSimulator.Model.Enum;

namespace ATMSimulator.Model.Entities
{
    public class Transaction : BaseEntity
    {
        public int? SenderCardId { get; set; }
        public int? ReceiverCardId { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal? Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionStatus Status { get; set; }
    }
}
