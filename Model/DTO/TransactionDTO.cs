using ATMSimulator.Model.Enum;

namespace ATMSimulator.Model.DTO
{
    public class TransactionDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? SenderAccountNumber { get; set; }
        public string? ReceiverAccountNumber { get; set; }
        public decimal? Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus Status { get; set; }
    }
}
