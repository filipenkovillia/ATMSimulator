using ATMSimulator.Model.DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ATMSimulator.Controller.AccountStatementExporter
{
    public class PDFStatementExporter : AccountStatementExporter
    {
        protected override void SaveToFile(List<TransactionDto> transactions)
        {
            Document document = new Document();

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("output.pdf", FileMode.Create));

            document.Open();

            PdfPTable table = new PdfPTable(6);

            table.AddCell("Sender Account");
            table.AddCell("Receiver Account");
            table.AddCell("Amount");
            table.AddCell("Transaction Type");
            table.AddCell("Transaction Date");
            table.AddCell("Status");

            foreach (var transaction in transactions)
            {
                table.AddCell(transaction.SenderCardNumber);
                table.AddCell(transaction.ReceiverCardNumber);
                table.AddCell(transaction.Amount.ToString());
                table.AddCell(transaction.TransactionType.ToString());
                table.AddCell(transaction.TransactionDate.ToString());
                table.AddCell(transaction.Status.ToString());
            }

            document.Add(table);

            document.Close();
        }
    }
}
