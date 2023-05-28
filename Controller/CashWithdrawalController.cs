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

        public CashWithdrawalController(Guid cardId)
        {
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardById(cardId);
        }

        private Card GetCardById(Guid cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        public bool WithdrawCash(decimal amount)
        {
            var account = GetAccountById(_card.AccountId);
            if(TryWithdrawAmountFromAccount(account, amount))
            {
                // TODO: create transaction based on result of method
                var transaction = CreateNewTransaction(amount);

                _dbContext.Transactions.Add(transaction);
                _dbContext.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
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
