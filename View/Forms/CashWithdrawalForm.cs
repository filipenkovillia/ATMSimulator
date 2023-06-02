using ATMSimulator.Controller;
using ATMSimulator.Controller.WithdrawalStrategy.Context;
using ATMSimulator.Controller.WithdrawalStrategy.Strategies;
using ATMSimulator.Session;

namespace ATMSimulator.View.Forms
{
    public partial class CashWithdrawalForm : Form
    {
        private readonly CashWithdrawalController _cashWithdrawalController;
        private WithdrawalContext _withdrawalContext;

        public CashWithdrawalForm()
        {
            InitializeComponent();
            _cashWithdrawalController = new CashWithdrawalController(UserSession.Instance.CardId);
            _withdrawalContext = new WithdrawalContext();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            _withdrawalContext.SetWithdrawalStrategy(new CustomAmountWithdrawalStrategy());

            var amount = _withdrawalContext.GetWithdrawAmountFromString(tbAmount.Text);
            var withdrawResult = _withdrawalContext.Withdraw(_cashWithdrawalController, amount);

            if (withdrawResult.IsSuccess)
            {
                MessageBox.Show($"Withdrawal successful! Amount: ${amount}");
            }
            else
            {
                MessageBox.Show($"Withdrawal failed. Please try again. " +
                    $"Error message: {withdrawResult.Message}");
            }

            tbAmount.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void btnFast10_Click(object sender, EventArgs e)
        {
            FastCashButtonClick(btnFast10);
        }

        private void btnFast20_Click(object sender, EventArgs e)
        {
            FastCashButtonClick(btnFast20);
        }

        private void btnFast50_Click(object sender, EventArgs e)
        {
            FastCashButtonClick(btnFast50);
        }

        private void btnFast100_Click(object sender, EventArgs e)
        {
            FastCashButtonClick(btnFast100);
        }

        private void FastCashButtonClick(Button button)
        {
            _withdrawalContext.SetWithdrawalStrategy(new FashCashWithdrawalStrategy());

            var amount = _withdrawalContext.GetWithdrawAmountFromString(button.Text);
            var withdrawResult = _withdrawalContext.Withdraw(_cashWithdrawalController, amount);

            if (withdrawResult.IsSuccess)
            {
                MessageBox.Show($"Withdrawal successful! Amount: ${amount}");
            }
            else
            {
                MessageBox.Show($"Withdrawal failed. Please try again. " +
                    $"Error message: {withdrawResult.Message}");
            }

            tbAmount.Text = string.Empty;
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
