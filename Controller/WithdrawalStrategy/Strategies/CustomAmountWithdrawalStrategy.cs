using ATMSimulator.Controller.WithdrawalStrategy.Interfaces;
using ATMSimulator.Model.DTO;

namespace ATMSimulator.Controller.WithdrawalStrategy.Strategies
{
    public class CustomAmountWithdrawalStrategy : IWithdrawalStrategy
    {
        public decimal GetWithdrawAmountFromString(string input)
        {
            return decimal.Parse(input);
        }

        public FormActionResultDto Withdraw(CashWithdrawalController controller, decimal amount)
        {
            if (!controller.CanDivideAmountByBanknotes(amount))
            {
                controller.CreateNewTransaction(amount, Model.Enum.TransactionStatus.Failed);

                return new FormActionResultDto
                {
                    IsSuccess = false,
                    Message = "Withdraw amount must be dividable by 10."
                };
            }
            else
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
}
