using ATMSimulator.Controller;
using ATMSimulator.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            _loginController.AuthenticateUser(cardNumber, pin);

            if (UserSession.Instance.IsLoggedIn())
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
    }
}
