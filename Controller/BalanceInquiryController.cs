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

        public BalanceInquiryController(Account account) 
        { 
            _dbContext = DbContextProvider.Instance.GetDbContext();
        }

        public decimal GetAccountBalance()
        {
            return _account.Balance;
        }
    }
}
