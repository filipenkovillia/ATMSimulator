using ATMSimulator.Controller.ReceiptFactory.Receipts;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;

namespace ATMSimulator.Controller.ReceiptFactory
{
    public static class ReceiptFactory
    {
        public static Receipt CreateReceipt(Transaction transaction)
        {
            switch (transaction.TransactionType)
            {
                case TransactionType.Withdrawal:
                    return new WithdrawalReceipt(transaction);
                case TransactionType.Deposit:
                    return new DepositReceipt(transaction);
                case TransactionType.BalanceInquiry:
                    return new BalanceInquiryReceipt(transaction);
                case TransactionType.Transfer:
                    return new TransferReceipt(transaction);
                default:
                    throw new ArgumentException("Invalid transaction type");
            }
        }
    }
}
