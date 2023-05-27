using ATMSimulator.Model.AppDbContext;
using ATMSimulator.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Controller
{
    public class SignUpController
    {
        private readonly AppDbContext _dbContext;

        public SignUpController() 
        { 
            _dbContext = DbContextProvider.Instance.GetDbContext();
        }

        public bool TrySignUp(string firstName, string lastName, string phoneNumber)
        {
            if (ValidateInputData(firstName, lastName, phoneNumber))
            {
                var customer = CreateNewCustomer(firstName, lastName, phoneNumber);
                var account = CreateNewAccount(customer);
                var card = CreateNewCard(customer, account);

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

        private Account CreateNewAccount(Customer customer)
        {
            return new Account()
            {
                CreatedAt = DateTime.Now,
                AccountType = Model.Enum.AccountType.Unknown,
                Balance = 0,
                CustomerId = customer.Id,
                Number = GenerateAccountNumber(),
            };
        }

        private Card CreateNewCard(Customer customer, Account account)
        {
            return new Card()
            {
                CreatedAt = DateTime.Now,
                AccountId = account.Id,
                CardHolderName = $"{customer.FirstName} {customer.LastName}",
                CardType = Model.Enum.CardType.None,
                ExpireDate = DateTime.Now.AddYears(3),
                Number = GenerateCardNumber(),
                PIN = GenerateCardPIN(),
            };
        }

        private string GenerateAccountNumber()
        {
            return string.Empty;
        }

        private string GenerateCardNumber()
        {
            return string.Empty;
        }

        private string GenerateCardPIN()
        {
            return string.Empty;
        }
    }
}
