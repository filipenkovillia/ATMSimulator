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

        public WithdrawResultDto Withdraw(CashWithdrawalController controller, decimal amount)
        {
            controller.WithdrawCash(amount);

            return new WithdrawResultDto
            {
                IsSuccess = true,
                Message = $"Cash withdrawal for amount {amount} completed successfully."
            };
        }
    }
}
