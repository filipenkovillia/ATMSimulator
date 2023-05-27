using ATMSimulator.Model.AppDbContext;
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

        public bool AuthenticateUser(string cardNumber, string pin)
        {
            // Perform authentication logic here
            // Query the database to check if the username and password match

            var card = _dbContext.Cards
                .FirstOrDefault(c => c.Number == cardNumber 
                                  && c.PIN == pin);

            return card != null;
        }
    }
}
