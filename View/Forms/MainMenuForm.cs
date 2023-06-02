using ATMSimulator.Session;

namespace ATMSimulator.View.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            var form = new BalanceInquiryForm();
            form.Show();
            this.Close();
        }

        private void btnCashWithdrawal_Click(object sender, EventArgs e)
        {
            var form = new CashWithdrawalForm();
            form.Show();
            this.Close();
        }

        private void btnFundTransfer_Click(object sender, EventArgs e)
        {
            var form = new FundTransferForm();
            form.Show();
            this.Close();
        }

        private void btnAccountStatement_Click(object sender, EventArgs e)
        {
            var form = new AccountStatementForm();
            form.Show();
            this.Close();
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            var form = new ChangePinForm();
            form.Show();
            this.Close();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            UserSession.Instance.Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
