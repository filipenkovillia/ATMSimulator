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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {

        }

        private void btnCashWithdrawal_Click(object sender, EventArgs e)
        {

        }

        private void btnFundTransfer_Click(object sender, EventArgs e)
        {

        }

        private void btnAccountStatement_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {

        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
