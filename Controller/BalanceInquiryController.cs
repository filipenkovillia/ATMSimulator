using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;

namespace ATMSimulator.Controller
{
    public class BalanceInquiryController
    {
        private readonly AppDbContext _dbContext;
        private readonly Account _account;

        public BalanceInquiryController(Guid accountId) 
        { 
            _dbContext = DbContextProvider.GetDbContext();
            _account = GetAccountById(accountId);
        }

        private Account GetAccountById(Guid accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        public decimal GetAccountBalance()
        {
            var transaction = CreateNewTransaction(TransactionStatus.Success);

            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();

            return _account.Balance;
        }

        public Transaction CreateNewTransaction(TransactionStatus status)
        {
            return new Transaction()
            {
                Amount = null,
                CreatedAt = DateTime.UtcNow,
                TransactionDate = DateTime.UtcNow,
                Status = status,
                AccountFromId = _account.Id,
                AccountToId = null,
                TransactionType = TransactionType.BalanceInquiry
            };
        }
    }
}
