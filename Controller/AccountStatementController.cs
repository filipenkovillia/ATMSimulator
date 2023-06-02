using ATMSimulator.Controller.AccountStatementExporter;
using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;

namespace ATMSimulator.Controller
{
    public class AccountStatementController
    {
        private readonly AppDbContext _dbContext;
        private readonly Account _account;
        private readonly Card _card;

        public AccountStatementController(Guid accountId, Guid cardId) 
        {
            _dbContext = DbContextProvider.GetDbContext();
            _account = GetAccountById(accountId);
            _card = GetCardByID(cardId);
        }

        private Account GetAccountById(Guid accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        private Card GetCardByID(Guid cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        public List<Transaction> GetAccountTransactions()
        {
            return _dbContext.Transactions
                .Where(x => x.AccountToId == _account.Id
                         || x.AccountFromId == _account.Id)
                .ToList();
        }

        public Guid GetTransactionId(string transactionId)
        {
            Guid result = Guid.Empty;
            var isSuccess = Guid.TryParse(transactionId, out result);
            return result;
        }

        public Transaction? GetTransactionById(Guid transactionId) 
        {
            return _dbContext.Transactions
                .FirstOrDefault(x => x.Id == transactionId);
        }

        public string GetReceiptText(Guid transactionId)
        {
            var transaction = GetTransactionById(transactionId);

            if (transaction != null)
            {
                var receipt = ReceiptFactory.ReceiptFactory.CreateReceipt(transaction);
                return receipt.Print();
            }
            else
            {
                return $"Failed to print receipt.";
            }    
        }

        public void ExportAccountStatementToFile(ExportFormat format)
        {
            AccountStatementExporter.AccountStatementExporter exporter;

            switch (format)
            {
                case ExportFormat.PDF:
                    exporter = new PDFStatementExporter();
                    break;
                case ExportFormat.XLSX:
                    exporter = new ExcelStatementExporter();
                    break;
                case ExportFormat.CSV:
                    exporter= new CSVStatementExporter();
                    break;
                default:
                    throw new Exception("No format for export selected.");
            }

            exporter.Export(_card.Id);
        }
    }
}
