using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller
{
    public class ChangePinController
    {
        private readonly AppDbContext _dbContext;
        private readonly Card _card;

        public ChangePinController(int cardId) 
        {
            _dbContext = DbContextProvider.GetDbContext();
            _card = GetCardById(cardId);
        }

        private Card GetCardById(int cardId)
        {
            return _dbContext.Cards.FirstOrDefault(x => x.Id == cardId);
        }

        public bool IsCurrentPinCorrect(string currentPin)
        {
            return _card.PIN == currentPin;
        }

        public void SaveNewPin(string newPin)
        {
            _card.PIN = newPin;
            _card.UpdatedAt = DateTime.Now;

            _dbContext.Cards.Update(_card);
            _dbContext.SaveChanges();
        }
    }
}
