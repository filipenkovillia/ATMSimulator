using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.DTO;
using ATMSimulator.Model.Entities;
using System.Text;

namespace ATMSimulator.Controller
{
    public class FundTransferController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;

        public FundTransferController(int cardId)
        {
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardById(cardId);
        }

        public FormActionResultDto TransferFunds(string cardNumberTo, decimal amount)
        {
            var validationResult = ValidateTransferParameters(cardNumberTo, amount);

            if (validationResult.Length == 0)
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

                return new FormActionResultDto
                {
                    IsSuccess = true,
                    Message = $"Transferred {amount}$ to {cardNumberTo} successfully."
                };
            }
            else
            {
                return new FormActionResultDto
                {
                    IsSuccess = false,
                    Message = validationResult.ToString(),
                };
            }    
        }

        private StringBuilder ValidateTransferParameters(string cardNumberTo, decimal amount)
        {
            var sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(cardNumberTo))
            {
                sb.AppendLine("Recipient Card Number cannot be empty.");
            }
            if (amount <= 0)
            {
                sb.AppendLine("Transfer Amount must be more than 0$.");
            }

            var recipientCardExists = _dbContext.Cards
                .Any(x => x.Number == cardNumberTo);

            if (!recipientCardExists)
            {
                sb.AppendLine($"Recipient with Card Number = {cardNumberTo} does not exist.");
            }

            var isEnoughBalance = _card.Balance >= amount;

            if (!isEnoughBalance)
            {
                sb.AppendLine($"Card balance is not enough to make transfer for {amount}$.");
            }

            return sb;
        }

        private Card GetCardByNumber(string cardNumber)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Number == cardNumber);
        }

        private Card GetCardById(int cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        private Transaction CreateNewTransaction(int accountFromId, int accountToId, decimal amount)
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
