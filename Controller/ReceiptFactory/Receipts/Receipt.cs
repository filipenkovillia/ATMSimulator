using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller.ReceiptFactory.Receipts
{
    public abstract class Receipt
    {
        protected readonly Transaction _transaction;

        public Receipt(Transaction transaction)
        {
            _transaction = transaction;
        }

        public abstract string Print();
    }
}
