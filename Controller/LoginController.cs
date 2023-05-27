using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using ATMSimulator.Session;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class LoginController
    {
        private readonly AppDbContext _dbContext;

        public LoginController() 
        {
            _dbContext = DbContextProvider.Instance.GetDbContext();
        }

        public void AuthenticateUser(string cardNumber, string pin)
        {
            var card = _dbContext.Cards
                .FirstOrDefault(c => c.Number == cardNumber 
                                  && c.PIN == pin);

            if (card != null)
            {
                UserSession.Instance.CardId = card.Id;
                UserSession.Instance.AccountId = card.AccountId;
            }
        }
    }
}
