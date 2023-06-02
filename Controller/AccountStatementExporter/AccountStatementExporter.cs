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

        public void Export(Guid cardId)
        {
            var transactions = PrepareData(cardId);
            SaveToFile(transactions);
        }

        protected List<TransactionDTO> PrepareData(Guid cardId)
        {
            var card = _dbContext.Cards
                .FirstOrDefault(c => c.Id == cardId);

            var transactions = (from tr in _dbContext.Transactions
                                join cardFrom in _dbContext.Cards on tr.SenderCardId equals cardFrom.Id into cardFromJoin
                                from accFromResult in cardFromJoin.DefaultIfEmpty()
                                join cardTo in _dbContext.Cards on tr.ReceiverCardId equals cardTo.Id into cardToJoin
                                from accToResult in cardToJoin.DefaultIfEmpty()
                                where tr.SenderCardId == card.Id || tr.ReceiverCardId == card.Id
                                orderby tr.TransactionDate
                                select new TransactionDTO
                                {
                                    Id = tr.Id,
                                    CreatedAt = tr.CreatedAt,
                                    UpdatedAt = tr.UpdatedAt,
                                    SenderAccountNumber = accFromResult.Number,
                                    ReceiverAccountNumber = accToResult.Number,
                                    TransactionDate = tr.TransactionDate,
                                    Amount = tr.Amount,
                                    TransactionType = tr.TransactionType,
                                    Status = tr.Status
                                })
                                .ToList();

            return transactions;
        }

        protected abstract void SaveToFile(List<TransactionDTO> transactions);
    }
}
