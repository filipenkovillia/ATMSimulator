using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class ReceiptController
    {
        private readonly AppDbContext _dbContext;
        private readonly Transaction _transaction;

        public ReceiptController(Guid transactionId) 
        { 
            _transaction = GetTransactionById(transactionId);
        }

        private Transaction GetTransactionById(Guid transactionId)
        {
            return _dbContext.Transactions.FirstOrDefault(x => x.Id == transactionId);
        }

        public Transaction GetTransaction()
        {
            return _transaction;
        }
    }
}
