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
    public partial class ChangePinForm : Form
    {
        public ChangePinForm()
        {
            InitializeComponent();
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            string currentPIN = tbCurrentPIN.Text; // Get the current PIN from the input textbox
            string newPIN = tbNewPIN.Text; // Get the new PIN from the input textbox

            // Perform change PIN logic
            bool pinChanged = false;//ChangePIN(currentPIN, newPIN); // Replace with your own change PIN logic

            if (pinChanged)
            {
                MessageBox.Show("PIN changed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to change PIN. Please try again.");
            }

            // Clear the input textboxes
            tbCurrentPIN.Text = string.Empty;
            tbNewPIN.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
