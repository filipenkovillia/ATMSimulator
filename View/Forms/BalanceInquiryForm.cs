using ATMSimulator.Controller;
using ATMSimulator.Session;

namespace ATMSimulator.View.Forms
{
    public partial class BalanceInquiryForm : Form
    {
        private readonly BalanceInquiryController _balanceInquiryController;

        public BalanceInquiryForm()
        {
            InitializeComponent();
            _balanceInquiryController = new BalanceInquiryController(UserSession.Instance.CardId);
        }

        private void BalanceInquiryForm_Load(object sender, EventArgs e)
        {
            decimal accountBalance = _balanceInquiryController.GetCardBalance();

            lbBalance.Text = $"Card Balance: ${accountBalance}";
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }
    }
}
