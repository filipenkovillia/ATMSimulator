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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            var form = new BalanceInquiryForm();
            form.Show();
            this.Hide();
        }

        private void btnCashWithdrawal_Click(object sender, EventArgs e)
        {
            var form = new CashWithdrawalForm();
            form.Show();
            this.Hide();
        }

        private void btnFundTransfer_Click(object sender, EventArgs e)
        {
            var form = new FundTransferForm();
            form.Show();
            this.Hide();
        }

        private void btnAccountStatement_Click(object sender, EventArgs e)
        {
            var form = new AccountStatementForm();
            form.Show();
            this.Hide();
        }

        private void btnChangePin_Click(object sender, EventArgs e)
        {
            var form = new ChangePinForm();
            form.Show();
            this.Hide();
        }

        private void lbLogout_Click(object sender, EventArgs e)
        {
            UserSession.Instance.Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
