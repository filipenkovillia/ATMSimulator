using ATMSimulator.Controller;
using ATMSimulator.Model.Entities;
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
    public partial class BalanceInquiryForm : Form
    {
        private readonly BalanceInquiryController _balanceInquiryController;

        public BalanceInquiryForm()
        {
            InitializeComponent();
            _balanceInquiryController = new BalanceInquiryController(UserSession.Instance.AccountId);
        }

        private void BalanceInquiryForm_Load(object sender, EventArgs e)
        {
            decimal accountBalance = _balanceInquiryController.GetAccountBalance();

            lbBalance.Text = $"Account Balance: ${accountBalance}";
        }

        private void lbBack_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }
    }
}
