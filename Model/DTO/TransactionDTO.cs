using ATMSimulator.Model.Enum;

namespace ATMSimulator.Model.DTO
{
    public class TransactionDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? SenderCardNumber { get; set; }
        public string? ReceiverCardNumber { get; set; }
        public decimal? Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus Status { get; set; }
    }
}
