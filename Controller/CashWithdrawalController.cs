using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;

namespace ATMSimulator.Controller
{
    public class CashWithdrawalController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;
        private readonly Account _account;

        public CashWithdrawalController(Guid cardId, Guid accountId)
        {
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardById(cardId);
            _account = GetAccountById(accountId);
        }

        public void WithdrawCash(decimal amount)
        {
            _account.Balance -= amount;

            var transaction = CreateNewTransaction(amount, TransactionStatus.Success);

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
                AccountFromId = _card.AccountId,
                AccountToId = null,
                TransactionType = TransactionType.Withdrawal
            };
        }

        public bool CanWithdrawAmount(decimal amount)
        {
            return _account.Balance >= amount;
        }
        
        public bool CanDivideAmountByBanknotes(decimal amount)
        {
            return amount % 10 == 0;
        }

        private Card GetCardById(Guid cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        private Account GetAccountById(Guid accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);
        }
    }
}
