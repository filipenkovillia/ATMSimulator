using ATMSimulator.Controller;
using ATMSimulator.Session;

namespace ATMSimulator.View.Forms
{
    public partial class FundTransferForm : Form
    {
        private readonly FundTransferController _fundTransferController;

        public FundTransferForm()
        {
            InitializeComponent();
            _fundTransferController = new FundTransferController(UserSession.Instance.CardId);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string recipientCard = tbRecipientCard.Text;
            decimal transferAmount = decimal.Parse(tbAmount.Text); 
            
            var transferResult = _fundTransferController.TransferFunds(recipientCard, transferAmount);
            if (transferResult.IsSuccess)
            {
                MessageBox.Show(transferResult.Message);
            }
            else
            {
                MessageBox.Show($"Failed to transfer funds. Please, try again.\n{transferResult.Message}");
            }

            tbRecipientCard.Text = string.Empty;
            tbAmount.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRecipientCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
