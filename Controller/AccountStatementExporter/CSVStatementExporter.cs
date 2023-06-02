using ATMSimulator.Model.DTO;

namespace ATMSimulator.Controller.AccountStatementExporter
{
    public class CSVStatementExporter : AccountStatementExporter
    {
        protected override void SaveToFile(List<TransactionDto> transactions)
        {
            using (StreamWriter writer = new StreamWriter("output.csv"))
            {
                writer.WriteLine("SenderAccountNumber,ReceiverAccountNumber," +
                    "Amount,TransactionType,TransactionDate,Status");

                foreach (var transaction in transactions)
                {
                    writer.WriteLine($"{transaction.SenderCardNumber},{transaction.ReceiverCardNumber}," +
                        $"{transaction.Amount},{transaction.TransactionType},{transaction.TransactionDate}," +
                        $"{transaction.Status}");
                }
            }
        }
    }
}
