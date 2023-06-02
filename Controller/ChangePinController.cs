using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.DTO;
using ATMSimulator.Model.Entities;
using System.Text;

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

        public FormActionResultDto ChangePIN(string currentPIN, string newPIN, string confirmNewPIN)
        {
            var validationResult = ValidatePIN(currentPIN, newPIN, confirmNewPIN);

            if (validationResult.Length == 0)
            {
                SaveNewPin(newPIN);

                return new FormActionResultDto
                {
                    IsSuccess = true,
                };
            }
            else
            {
                return new FormActionResultDto
                {
                    IsSuccess = false,
                    Message = validationResult.ToString(),
                };
            }
        }

        private StringBuilder ValidatePIN(string currentPIN, string newPIN, string confirmNewPIN)
        {
            var sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentPIN) 
                || string.IsNullOrWhiteSpace(newPIN) 
                || string.IsNullOrWhiteSpace(confirmNewPIN))
            {
                sb.AppendLine("PIN cannot be empty.");
            }
            if (_card.PIN != currentPIN)
            {
                sb.AppendLine("Current PIN is incorrect.");
            }
            if (currentPIN == newPIN)
            {
                sb.AppendLine("New PIN cannot be the same as current PIN.");
            }
            if (newPIN != confirmNewPIN)
            {
                sb.AppendLine("Failed to confirm new PIN.");
            }

            return sb;
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
