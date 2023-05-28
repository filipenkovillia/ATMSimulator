using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class BalanceInquiryController
    {
        private readonly AppDbContext _dbContext;
        private readonly Account _account;

        public BalanceInquiryController(Guid accountId) 
        { 
            _dbContext = DbContextProvider.GetDbContext();
            _account = GetAccountById(accountId);
        }

        private Account GetAccountById(Guid accountId)
        {
            return _dbContext.Accounts.FirstOrDefault(x => x.Id == accountId);
        }

        public decimal GetAccountBalance()
        {
            return _account.Balance;
        }
    }
}
