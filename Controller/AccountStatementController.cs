using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class AccountStatementController
    {
        private readonly AppDbContext _dbContext;
        private readonly Account _account;

        public AccountStatementController(Guid accountId) 
        {
            _dbContext = DbContextProvider.Instance.GetDbContext();
            _account = GetAccountById(accountId);
        }

        private Account GetAccountById(Guid accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        public List<Transaction> GetAccountTransactions()
        {
            return _dbContext.Transactions
                .Where(x => x.AccountToId == _account.Id
                         || x.AccountFromId == _account.Id)
                .ToList();
        }

        public Guid GetTransactionId(string transactionId)
        {
            Guid result = Guid.Empty;
            var isSuccess = Guid.TryParse(transactionId, out result);
            return result;
        }
    }
}
