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
    public partial class FundTransferForm : Form
    {
        private readonly FundTransferController _fundTransferController;

        public FundTransferForm()
        {
            InitializeComponent();
            _fundTransferController = new FundTransferController(UserSession.Instance.AccountId);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string recipientCard = tbRecipientCard.Text;
            decimal transferAmount = decimal.Parse(tbAmount.Text); 
            
            // TODO: add checks for incorrect transaction
            _fundTransferController.TransferFunds(recipientCard, transferAmount);

            tbRecipientCard.Text = string.Empty;
            tbAmount.Text = string.Empty;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }
    }
}
