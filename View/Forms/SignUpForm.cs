using ATMSimulator.Controller;

namespace ATMSimulator.View.Forms
{
    public partial class SignUpForm : Form
    {
        private readonly SignUpController _signUpController;

        public SignUpForm()
        {
            InitializeComponent();
            _signUpController = new SignUpController();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string phoneNumber = tbPhoneNumber.Text;

            var signUpResult = _signUpController.SignUp(firstName, lastName, phoneNumber);

            if (signUpResult.IsSuccess)
            {
                MessageBox.Show($"Sign-up successful!\n{signUpResult.Message}");

                tbFirstName.Text = string.Empty;
                tbLastName.Text = string.Empty;
                tbPhoneNumber.Text = string.Empty;

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show($"Failed to sign up. Please try again.\n{signUpResult.Message}");
            }
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
