using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;

namespace ATMSimulator.Controller
{
    public class BalanceInquiryController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;

        public BalanceInquiryController(int cardId) 
        { 
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardById(cardId);
        }

        private Card GetCardById(int cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        public decimal GetCardBalance()
        {
            var transaction = CreateNewTransaction(TransactionStatus.Success);

            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();

            return _card.Balance;
        }

        public Transaction CreateNewTransaction(TransactionStatus status)
        {
            return new Transaction()
            {
                Amount = null,
                CreatedAt = DateTime.UtcNow,
                TransactionDate = DateTime.UtcNow,
                Status = status,
                SenderCardId = _card.Id,
                ReceiverCardId = null,
                TransactionType = TransactionType.BalanceInquiry
            };
        }
    }
}
