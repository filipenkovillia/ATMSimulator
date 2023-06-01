using ATMSimulator.Controller.Authorization.Interfaces;
using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller.Authorization
{
    public class UserAuthorizationProxy : IUserAuthorization
    {
        private readonly IUserAuthorization _userAuthorization;
        private readonly AppDbContext _dbContext;

        public UserAuthorizationProxy(IUserAuthorization userAuthorization)
        {
            _userAuthorization = userAuthorization;
            _dbContext = DbContextProvider.GetDbContext();
        }

        public bool AuthorizeUser(string cardNumber, string pin)
        {
            bool isAuthorized = _userAuthorization.AuthorizeUser(cardNumber, pin);

            LogAuthorizationResult(cardNumber, isAuthorized);

            return isAuthorized;
        }

        private void LogAuthorizationResult(string cardNumber, bool isAuthorized)
        {
            var logRecord = new AuthorizationLog
            {
                CreatedAt = DateTime.Now,
                CardNumber = cardNumber,
                Result = isAuthorized
            };

            _dbContext.AuthorizationLogs.Add(logRecord);
            _dbContext.SaveChanges();
        }
    }
}
