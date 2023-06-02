using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller.ReceiptFactory.Receipts
{
    public class DepositReceipt : Receipt
    {
        public DepositReceipt(Transaction transaction)
            : base(transaction)
        {

        }

        public override string Print()
        {
            return $"Deposit Receipt\n" +
                $"Receiver Account: {_transaction.ReceiverCardId}\n" +
                $"Amount: {_transaction.Amount}\n" +
                $"Status: {Enum.GetName(_transaction.Status)}\n" +
                $"Transaction Date: {_transaction.TransactionDate}";
        }
    }
}
