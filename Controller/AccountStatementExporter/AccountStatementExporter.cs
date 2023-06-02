using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.DTO;

namespace ATMSimulator.Controller.AccountStatementExporter
{
    public abstract class AccountStatementExporter
    {
        private readonly AppDbContext _dbContext;

        public AccountStatementExporter()
        {
            _dbContext = DbContextProvider.GetDbContext();
        }

        public void Export(int cardId)
        {
            var transactions = PrepareData(cardId);
            SaveToFile(transactions);
        }

        protected List<TransactionDto> PrepareData(int cardId)
        {
            var card = _dbContext.Cards
                .FirstOrDefault(c => c.Id == cardId);

            var transactions = (from tr in _dbContext.Transactions
                                join cardFrom in _dbContext.Cards on tr.SenderCardId equals cardFrom.Id into cardFromJoin
                                from cardFromResult in cardFromJoin.DefaultIfEmpty()
                                join cardTo in _dbContext.Cards on tr.ReceiverCardId equals cardTo.Id into cardToJoin
                                from cardToResult in cardToJoin.DefaultIfEmpty()
                                where tr.SenderCardId == card.Id || tr.ReceiverCardId == card.Id
                                orderby tr.TransactionDate
                                select new TransactionDto
                                {
                                    Id = tr.Id,
                                    CreatedAt = tr.CreatedAt,
                                    UpdatedAt = tr.UpdatedAt,
                                    SenderCardNumber = cardFromResult.Number,
                                    ReceiverCardNumber = cardToResult.Number,
                                    TransactionDate = tr.TransactionDate,
                                    Amount = tr.Amount,
                                    TransactionType = tr.TransactionType,
                                    Status = tr.Status
                                })
                                .ToList();

            return transactions;
        }

        protected abstract void SaveToFile(List<TransactionDto> transactions);
    }
}
