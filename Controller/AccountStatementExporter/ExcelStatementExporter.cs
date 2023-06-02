using ATMSimulator.Model.DTO;
using OfficeOpenXml;

namespace ATMSimulator.Controller.AccountStatementExporter
{
    public class ExcelStatementExporter : AccountStatementExporter
    {
        protected override void SaveToFile(List<TransactionDto> transactions)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Transactions");

                worksheet.Cells[1, 1].Value = "Sender Account";
                worksheet.Cells[1, 2].Value = "Receiver Account";
                worksheet.Cells[1, 3].Value = "Amount";
                worksheet.Cells[1, 4].Value = "Transaction Type";
                worksheet.Cells[1, 5].Value = "Transaction Date";
                worksheet.Cells[1, 6].Value = "Status";

                for (int i = 0; i < transactions.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = transactions[i].SenderCardNumber;
                    worksheet.Cells[i + 2, 2].Value = transactions[i].ReceiverCardNumber;
                    worksheet.Cells[i + 2, 3].Value = transactions[i].Amount;
                    worksheet.Cells[i + 2, 4].Value = transactions[i].TransactionType;
                    worksheet.Cells[i + 2, 5].Value = transactions[i].TransactionDate;
                    worksheet.Cells[i + 2, 6].Value = transactions[i].Status;
                }

                worksheet.Cells.AutoFitColumns();

                File.WriteAllBytes("output.xlsx", package.GetAsByteArray());
            }
        }
    }
}
