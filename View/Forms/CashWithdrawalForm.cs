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
    public partial class CashWithdrawalForm : Form
    {
        public CashWithdrawalForm()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal withdrawalAmount = decimal.Parse(tbAmount.Text); // Get the withdrawal amount from the input textbox

            // Perform withdrawal logic, deduct the amount from the user's account balance
            bool withdrawalSuccessful = false;//PerformWithdrawal(withdrawalAmount); // Replace with your own withdrawal logic

            if (withdrawalSuccessful)
            {
                MessageBox.Show($"Withdrawal successful! Amount: ${withdrawalAmount}");
            }
            else
            {
                MessageBox.Show("Withdrawal failed. Please try again.");
            }

            // Clear the input textbox
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
