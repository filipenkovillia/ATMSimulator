using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class CashWithdrawalController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;

        public CashWithdrawalController(Card card)
        {
            _dbContext = DbContextProvider.Instance.GetDbContext();
            _card = card;
        }

        public void WithdrawCash(decimal amount)
        {
            var account = GetAccountById(_card.AccountId);
            TryWithdrawAmountFromAccount(account, amount);

            // TODO: create transaction based on result of method
            var transaction = CreateNewTransaction(amount);

            _dbContext.SaveChanges();
        }

        private Account GetAccountById(Guid accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        private Transaction CreateNewTransaction(decimal amount)
        {
            return new Transaction()
            {
                Amount = amount,
                CreatedAt = DateTime.UtcNow,
                TransactionDate = DateTime.UtcNow,
                Status = Model.Enum.TransactionStatus.Success,
                AccountFromId = _card.AccountId,
                AccountToId = null,
                TransactionType = Model.Enum.TransactionType.Withdrawal
            };
        }

        private bool TryWithdrawAmountFromAccount(Account account, decimal amount)
        {
            if (account.Balance < amount)
            {
                return false;
            }
            else
            {
                account.Balance -= amount;
                return true;
            }
        }
    }
}
