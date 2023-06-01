using ATMSimulator.Controller.Authorization.Interfaces;
using ATMSimulator.Controller.Authorization;

namespace ATMSimulator.Controller
{
    public class LoginController
    {
        private readonly IUserAuthorization _userAuthorization;

        public LoginController() 
        {
            _userAuthorization = new UserAuthorizationProxy(new UserAuthorization());
        }

        public bool AuthenticateUser(string cardNumber, string pin)
        {
            return _userAuthorization.AuthorizeUser(cardNumber, pin);
        }
    }
}
