using ATMSimulator.Controller.WithdrawalStrategy.Interfaces;
using ATMSimulator.Model.DTO;

namespace ATMSimulator.Controller.WithdrawalStrategy.Context
{
    public class WithdrawalContext
    {
        private IWithdrawalStrategy _strategy;

        public void SetWithdrawalStrategy(IWithdrawalStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal GetWithdrawAmountFromString(string input)
        {
            return _strategy?.GetWithdrawAmountFromString(input) ?? 0;
        }

        public FormActionResultDto Withdraw(CashWithdrawalController controller, decimal amount)
        {
            if (controller.CanWithdrawAmount(amount))
            {
                return _strategy?.Withdraw(controller, amount);
            }
            else
            {
                controller.CreateNewTransaction(amount, Model.Enum.TransactionStatus.Failed);

                return new FormActionResultDto
                {
                    IsSuccess = false,
                    Message = "Not enough balance on account."
                };
            }
        }
    }
}
