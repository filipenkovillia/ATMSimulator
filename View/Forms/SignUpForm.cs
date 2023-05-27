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
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = tbFirstName.Text; // Get the first name from the input textbox
            string lastName = tbLastName.Text; // Get the last name from the input textbox
            string phoneNumber = tbPhoneNumber.Text; // Get the email from the input textbox

            // Perform sign-up logic
            bool signUpSuccessful = false;//SignUp(firstName, lastName, phoneNumber, password); // Replace with your own sign-up logic

            if (signUpSuccessful)
            {
                MessageBox.Show("Sign-up successful!");
            }
            else
            {
                MessageBox.Show("Failed to sign up. Please try again.");
            }

            // Clear the input textboxes
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbPhoneNumber.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
