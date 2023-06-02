using ATMSimulator.Controller.WithdrawalStrategy.Interfaces;
using ATMSimulator.Model.DTO;

namespace ATMSimulator.Controller.WithdrawalStrategy.Strategies
{
    public class FashCashWithdrawalStrategy : IWithdrawalStrategy
    {
        public decimal GetWithdrawAmountFromString(string input)
        {
            string[] arr = input.Split(' ');
            return decimal.Parse(arr[0]);
        }

        public FormActionResultDto Withdraw(CashWithdrawalController controller, decimal amount)
        {
            controller.WithdrawCash(amount);

            return new FormActionResultDto
            {
                IsSuccess = true,
                Message = $"Cash withdrawal for amount {amount} completed successfully."
            };
        }
    }
}
