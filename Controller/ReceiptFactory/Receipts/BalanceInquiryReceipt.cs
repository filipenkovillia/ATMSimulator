using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller.ReceiptFactory.Receipts
{
    public class BalanceInquiryReceipt : Receipt
    {
        public BalanceInquiryReceipt(Transaction transaction)
            : base(transaction)
        {

        }

        public override string Print()
        {
            return $"Balance Inquiry Receipt\n" +
                $"Account: {_transaction.SenderCardId}\n" +
                $"Status: {Enum.GetName(_transaction.Status)}\n" +
                $"Transaction Date: {_transaction.TransactionDate}";
        }
    }
}
