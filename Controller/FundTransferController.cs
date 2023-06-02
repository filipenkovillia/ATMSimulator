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
        private readonly Card _card;

        public FundTransferController(Guid cardId)
        {
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardById(cardId);
        }

        public void TransferFunds(string cardNumberTo, decimal amount)
        {
            var cardTo = GetCardByNumber(cardNumberTo);

            var transaction = CreateNewTransaction(_card.Id, cardTo.Id, amount);

            _card.Balance -= amount;
            cardTo.Balance += amount;
            _card.UpdatedAt = DateTime.Now;
            cardTo.UpdatedAt = DateTime.Now;

            _dbContext.Cards.Update(_card);
            _dbContext.Cards.Update(cardTo);
            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();
        }

        private Card GetCardByNumber(string cardNumber)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Number == cardNumber);
        }

        private Card GetCardById(Guid cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        private Transaction CreateNewTransaction(Guid accountFromId, Guid accountToId, decimal amount)
        {
            return new Transaction()
            {
                CreatedAt = DateTime.Now,
                TransactionDate = DateTime.Now,
                SenderCardId = accountFromId,
                ReceiverCardId = accountToId,
                Amount = amount,
                Status = Model.Enum.TransactionStatus.Success,
                TransactionType = Model.Enum.TransactionType.Transfer
            };
        }
    }
}
