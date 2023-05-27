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
        public BalanceInquiryForm()
        {
            InitializeComponent();
        }

        private void BalanceInquiryForm_Load(object sender, EventArgs e)
        {
            decimal accountBalance = 0;//GetAccountBalance(); // Replace with your own logic to retrieve the account balance

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
