using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;

namespace ATMSimulator.Controller
{
    public class SignUpController
    {
        private readonly AppDbContext _dbContext;

        public SignUpController() 
        { 
            _dbContext = DbContextProvider.GetDbContext();
        }

        public bool TrySignUp(string firstName, string lastName, string phoneNumber)
        {
            // TODO: return generated card number and PIN
            if (ValidateInputData(firstName, lastName, phoneNumber))
            {
                var customer = CreateNewCustomer(firstName, lastName, phoneNumber);
                var card = CreateNewCard(customer);

                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();

                card.CustomerId = customer.Id;
                _dbContext.Cards.Add(card);
                _dbContext.SaveChanges();

                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidateInputData(string firstName, string lastName, string phoneNumber)
        {
            // TODO: validation
            return true;
        }

        private Customer CreateNewCustomer(string firstName, string lastName, string phoneNumber)
        {
            return new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                CreatedAt = DateTime.Now,
            };
        }

        private Card CreateNewCard(Customer customer)
        {
            return new Card()
            {
                CreatedAt = DateTime.Now,
                CustomerId = customer.Id,
                CardHolderName = $"{customer.FirstName} {customer.LastName}",
                CardType = Model.Enum.CardType.None,
                ExpireDate = DateTime.Now.AddYears(3),
                Number = GenerateCardNumber(),
                PIN = GenerateCardPIN(),
            };
        }

        private string GenerateCardNumber()
        {
            var lastAccount = _dbContext.Cards.OrderBy(x => x.CreatedAt).LastOrDefault();
            if (lastAccount != null)
            {
                var accountNumber = Convert.ToInt32(lastAccount.Number);
                return (accountNumber + 1).ToString();
            }
            else
            {
                return "1";
            }
        }

        private string GenerateCardPIN()
        {
            var lastAccount = _dbContext.Cards.OrderBy(x => x.CreatedAt).LastOrDefault();
            if (lastAccount != null)
            {
                var accountNumber = Convert.ToInt32(lastAccount.Number);
                return (accountNumber + 1).ToString();
            }
            else
            {
                return "1";
            }
        }
    }
}
