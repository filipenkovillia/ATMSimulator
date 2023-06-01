using ATMSimulator.Controller;
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

            bool signUpSuccessful = _signUpController.TrySignUp(firstName, lastName, phoneNumber);

            if (signUpSuccessful)
            {
                MessageBox.Show("Sign-up successful!");
            }
            else
            {
                MessageBox.Show("Failed to sign up. Please try again.");
            }

            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
