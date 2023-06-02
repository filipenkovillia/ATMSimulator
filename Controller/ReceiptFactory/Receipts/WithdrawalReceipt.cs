using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller.ReceiptFactory.Receipts
{
    public class WithdrawalReceipt : Receipt
    {
        public WithdrawalReceipt(Transaction transaction)
            : base(transaction)
        {

        }

        public override string Print()
        {
            return $"Withdrawal Receipt\n" +
                $"Account: {_transaction.SenderCardId}\n" +
                $"Amount: {_transaction.Amount}\n" +
                $"Status: {Enum.GetName(_transaction.Status)}\n" +
                $"Transaction Date: {_transaction.TransactionDate}";
        }
    }
}
