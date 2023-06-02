using ATMSimulator.Controller;

namespace ATMSimulator.View.Forms
{
    public partial class LoginForm : Form
    {
        private readonly LoginController _loginController;

        public LoginForm()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cardNumber = tbCardNumber.Text;
            string pin = tbPIN.Text;

            var authorizationResult = _loginController.AuthenticateUser(cardNumber, pin);

            if (authorizationResult)
            {
                MainMenuForm mainMenuForm = new MainMenuForm();
                mainMenuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect credentials");
            }
        }

        private void lbSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void tbCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
