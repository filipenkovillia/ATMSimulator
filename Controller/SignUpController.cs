using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.DTO;
using ATMSimulator.Model.Entities;
using System.Text;

namespace ATMSimulator.Controller
{
    public class SignUpController
    {
        private readonly AppDbContext _dbContext;

        public SignUpController() 
        { 
            _dbContext = DbContextProvider.GetDbContext();
        }

        public FormActionResultDto SignUp(string firstName, string lastName, string phoneNumber)
        {
            var validationStringBuilder = ValidateInputData(firstName, lastName, phoneNumber);

            if (validationStringBuilder.Length == 0)
            {
                var customer = CreateNewCustomer(firstName, lastName, phoneNumber);
                var card = CreateNewCard(customer);

                _dbContext.Customers.Add(customer);
                _dbContext.SaveChanges();

                card.CustomerId = customer.Id;
                _dbContext.Cards.Add(card);
                _dbContext.SaveChanges();

                var result = new FormActionResultDto
                {
                    IsSuccess = true,
                    Message = $"Card Number: {card.Number}\n" +
                              $"PIN: {card.PIN}"
                };

                return result;
            }
            else
            {
                var result = new FormActionResultDto
                {
                    IsSuccess = false,
                    Message = validationStringBuilder.ToString()
                };

                return result;
            }
        }

        private StringBuilder ValidateInputData(string firstName, string lastName, string phoneNumber)
        {
            var sb = new StringBuilder();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                sb.AppendLine("First name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(lastName))
            {
                sb.AppendLine("Last name cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                sb.AppendLine("Phone cannot be empty.");
            }

            var customerExists = _dbContext.Customers
                .Any(x => x.FirstName == firstName 
                       && x.LastName == lastName);

            if (customerExists)
            {
                sb.AppendLine($"Customer with First Name = {firstName} and " +
                    $"Last Name = {lastName} already exists.");
            }

            var phoneNumberExists = _dbContext.Customers
                .Any(x => x.PhoneNumber == phoneNumber);

            if (phoneNumberExists)
            {
                sb.AppendLine($"Phone number {phoneNumber} has already been registered.");
            }

            return sb;
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
            var lastAccount = _dbContext.Cards
                .OrderBy(x => x.CreatedAt)
                .LastOrDefault();

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
            var lastAccount = _dbContext.Cards
                .OrderBy(x => x.CreatedAt)
                .LastOrDefault();
            
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
