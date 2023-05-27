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
    public partial class FundTransferForm : Form
    {
        public FundTransferForm()
        {
            InitializeComponent();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string recipientAccount = tbRecipientAccount.Text; // Get the recipient account number from the input textbox
            decimal transferAmount = decimal.Parse(tbAmount.Text); // Get the transfer amount from the input textbox

            // Perform fund transfer logic
            bool transferSuccessful = false;//PerformFundTransfer(recipientAccount, transferAmount); // Replace with your own transfer logic

            if (transferSuccessful)
            {
                MessageBox.Show($"Fund transfer successful! Amount: ${transferAmount} to Account: {recipientAccount}");
            }
            else
            {
                MessageBox.Show("Fund transfer failed. Please try again.");
            }

            // Clear the input textboxes
            tbRecipientAccount.Text = string.Empty;
            tbAmount.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
