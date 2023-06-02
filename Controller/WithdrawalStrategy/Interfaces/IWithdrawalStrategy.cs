using ATMSimulator.Model.DTO;

namespace ATMSimulator.Controller.WithdrawalStrategy.Interfaces
{
    public interface IWithdrawalStrategy
    {
        decimal GetWithdrawAmountFromString(string input);
        FormActionResultDto Withdraw(CashWithdrawalController controller, decimal amount);
    }
}
