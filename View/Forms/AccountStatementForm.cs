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
    public partial class AccountStatementForm : Form
    {
        private readonly AccountStatementController _accountStatementController;

        public AccountStatementForm()
        {
            InitializeComponent();
            _accountStatementController = new AccountStatementController(UserSession.Instance.AccountId);
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void AccountStatementForm_Load(object sender, EventArgs e)
        {
            var accountStatement = _accountStatementController.GetAccountTransactions();

            foreach (var transaction in accountStatement)
            {
                ListViewItem item = new ListViewItem(transaction.TransactionDate.ToString());
                item.SubItems.Add(transaction.Id.ToString());
                item.SubItems.Add(transaction.AccountFromId.ToString());
                item.SubItems.Add(transaction.AccountToId.ToString());
                item.SubItems.Add(transaction.Status.ToString());
                item.SubItems.Add(transaction.TransactionDate.ToString());
                item.SubItems.Add(transaction.TransactionType.ToString());
                item.SubItems.Add(transaction.Amount.ToString());
                lvAccountStatement.Items.Add(item);
            }
        }

        private void lvAccountStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTransaction = lvAccountStatement.SelectedItems[0];

            Guid transactionId = _accountStatementController.GetTransactionId(selectedTransaction.SubItems[0].Text);
            if (transactionId != Guid.Empty)
            {
                var receiptForm = new ReceiptForm(transactionId);
                receiptForm.ShowDialog();
            }
        }
    }
}
