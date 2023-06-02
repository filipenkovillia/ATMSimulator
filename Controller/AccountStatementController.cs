using ATMSimulator.Controller.AccountStatementExporter;
using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;

namespace ATMSimulator.Controller
{
    public class AccountStatementController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;

        public AccountStatementController(int cardId) 
        {
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardByID(cardId);
        }

        private Card GetCardByID(int cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        public List<Transaction> GetAccountTransactions()
        {
            return _dbContext.Transactions
                .Where(x => x.ReceiverCardId == _card.Id
                         || x.SenderCardId == _card.Id)
                .ToList();
        }

        public int GetTransactionId(string transactionId)
        {
            int result = 0;
            var isSuccess = int.TryParse(transactionId, out result);
            return result;
        }

        public Transaction? GetTransactionById(int transactionId) 
        {
            return _dbContext.Transactions
                .FirstOrDefault(x => x.Id == transactionId);
        }

        public string GetReceiptText(int transactionId)
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
