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
    public partial class CashWithdrawalForm : Form
    {
        private readonly CashWithdrawalController _cashWithdrawalController;

        public CashWithdrawalForm()
        {
            InitializeComponent();
            _cashWithdrawalController = new CashWithdrawalController(UserSession.Instance.CardId);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal withdrawalAmount = decimal.Parse(tbAmount.Text);
            bool withdrawalSuccessful = _cashWithdrawalController.WithdrawCash(withdrawalAmount);

            if (withdrawalSuccessful)
            {
                MessageBox.Show($"Withdrawal successful! Amount: ${withdrawalAmount}");
            }
            else
            {
                MessageBox.Show("Withdrawal failed. Please try again.");
            }

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
