using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class ChangePinController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;

        public ChangePinController(Card card) 
        {
            _dbContext = DbContextProvider.Instance.GetDbContext();
            _card = card;
        }

        public bool IsCurrentPinCorrect(string currentPin)
        {
            return _card.PIN == currentPin;
        }

        public void SaveNewPin(string newPin)
        {
            _card.PIN = newPin;
            _dbContext.SaveChanges();
        }
    }
}
