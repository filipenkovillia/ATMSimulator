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

        public AccountStatementController(Account account) 
        {
            _dbContext = DbContextProvider.Instance.GetDbContext();
            _account = account;
        }

        public List<Transaction> GetAccountTransactions()
        {
            return _dbContext.Transactions
                .Where(x => x.AccountToId == _account.Id
                         || x.AccountFromId == _account.Id)
                .ToList();
        }
    }
}
