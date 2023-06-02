using ATMSimulator.Controller;
using ATMSimulator.Session;

namespace ATMSimulator.View.Forms
{
    public partial class ChangePinForm : Form
    {
        private readonly ChangePinController _changePinController;

        public ChangePinForm()
        {
            InitializeComponent();
            _changePinController = new ChangePinController(UserSession.Instance.CardId);
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            string currentPIN = tbCurrentPIN.Text;
            string newPIN = tbNewPIN.Text;
            string confirmNewPIN = tbConfirmNewPIN.Text;

            var changePINResult = _changePinController.ChangePIN(currentPIN, newPIN, confirmNewPIN);

            if (changePINResult.IsSuccess)
            {
                MessageBox.Show("PIN changed successfully!");
            }
            else
            {
                MessageBox.Show($"Failed to change PIN. Please try again.\n{changePINResult.Message}");
            }

            tbCurrentPIN.Text = string.Empty;
            tbNewPIN.Text = string.Empty;
            tbConfirmNewPIN.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void tbCurrentPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNewPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbConfirmNewPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
