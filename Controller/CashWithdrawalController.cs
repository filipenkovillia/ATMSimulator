using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;

namespace ATMSimulator.Controller
{
    public class CashWithdrawalController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;

        public CashWithdrawalController(int cardId)
        {
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardById(cardId);
        }

        public void WithdrawCash(decimal amount)
        {
            _card.Balance -= amount;
            _card.UpdatedAt = DateTime.Now;

            var transaction = CreateNewTransaction(amount, TransactionStatus.Success);

            _dbContext.Cards.Update(_card);
            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();
        }

        public Transaction CreateNewTransaction(decimal amount, TransactionStatus status)
        {
            return new Transaction()
            {
                Amount = amount,
                CreatedAt = DateTime.UtcNow,
                TransactionDate = DateTime.UtcNow,
                Status = status,
                SenderCardId = _card.Id,
                ReceiverCardId = null,
                TransactionType = TransactionType.Withdrawal
            };
        }

        public bool CanWithdrawAmount(decimal amount)
        {
            return _card.Balance >= amount;
        }
        
        public bool CanDivideAmountByBanknotes(decimal amount)
        {
            return amount % 10 == 0;
        }

        private Card GetCardById(int cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }
    }
}
