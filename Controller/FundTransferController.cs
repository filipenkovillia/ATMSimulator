using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class FundTransferController
    {
        private readonly AppDbContext _dbContext;
        private readonly Account _account;

        public FundTransferController(Guid accountId)
        {
            _dbContext = DbContextProvider.Instance.GetDbContext();
            _account = GetAccountById(accountId);
        }

        public void TransferFunds(string cardNumberTo, decimal amount)
        {
            var cardTo = GetCardByNumber(cardNumberTo);
            var accountTo = GetAccountById(cardTo.AccountId);
            var transaction = CreateNewTransaction(_account.Id, accountTo.Id, amount);

            _dbContext.SaveChanges();
        }

        private Card GetCardByNumber(string cardNumber)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Number == cardNumber);
        }

        private Account GetAccountById(Guid accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        private Transaction CreateNewTransaction(Guid accountFromId, Guid accountToId, decimal amount)
        {
            return new Transaction()
            {
                CreatedAt = DateTime.Now,
                TransactionDate = DateTime.Now,
                AccountFromId = accountFromId,
                AccountToId = accountToId,
                Amount = amount,
                Status = Model.Enum.TransactionStatus.Success,
                TransactionType = Model.Enum.TransactionType.Transfer
            };
        }
    }
}
