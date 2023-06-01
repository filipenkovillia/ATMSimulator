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

            // TODO: additional checks
            if (_changePinController.IsCurrentPinCorrect(currentPIN))
            {
                _changePinController.SaveNewPin(newPIN);
                MessageBox.Show("PIN changed successfully!");
            }
            else
            {
                MessageBox.Show("Failed to change PIN. Please try again.");
            }

            tbCurrentPIN.Text = string.Empty;
            tbNewPIN.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }
    }
}
