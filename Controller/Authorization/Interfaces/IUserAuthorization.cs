namespace ATMSimulator.Controller.Authorization.Interfaces
{
    public interface IUserAuthorization
    {
        bool AuthorizeUser(string cardNumber, string pin);
    }
}
