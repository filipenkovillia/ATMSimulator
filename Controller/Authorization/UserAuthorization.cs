using ATMSimulator.Controller.Authorization.Interfaces;
using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Session;

namespace ATMSimulator.Controller.Authorization
{
    public class UserAuthorization : IUserAuthorization
    {
        private readonly AppDbContext _dbContext;

        public UserAuthorization()
        {
            _dbContext = DbContextProvider.GetDbContext();
        }

        public bool AuthorizeUser(string cardNumber, string pin)
        {
            var card = _dbContext.Cards
                .FirstOrDefault(c => c.Number == cardNumber
                                  && c.PIN == pin);

            if (card != null)
            {
                UserSession.Instance.SetUserParameters(card.Id);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
