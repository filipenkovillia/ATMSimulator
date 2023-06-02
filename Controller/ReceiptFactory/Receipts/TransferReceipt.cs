using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller.ReceiptFactory.Receipts
{
    public class TransferReceipt : Receipt
    {
        public TransferReceipt(Transaction transaction)
            : base(transaction)
        {

        }

        public override string Print()
        {
            return $"Transfer Receipt\n" +
                $"Sender Account: {_transaction.SenderCardId}\n" +
                $"Receiver Account: {_transaction.ReceiverCardId}\n" +
                $"Amount: {_transaction.Amount}\n" +
                $"Status: {Enum.GetName(_transaction.Status)}\n" +
                $"Transaction Date: {_transaction.TransactionDate}";
        }
    }
}
