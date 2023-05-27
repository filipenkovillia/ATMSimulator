using ATMSimulator.Model.Entities;
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
        public AccountStatementForm()
        {
            InitializeComponent();
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void AccountStatementForm_Load(object sender, EventArgs e)
        {
            var accountStatement = new List<Transaction>();//GetAccountStatement(); // Replace with your own logic to retrieve the account statement

            // Display the account statement in the list view
            foreach (var transaction in accountStatement)
            {
                ListViewItem item = new ListViewItem(transaction.TransactionDate.ToString());
                item.SubItems.Add(transaction.AccountToId.ToString());
                item.SubItems.Add(transaction.Amount.ToString());
                lvAccountStatement.Items.Add(item);
            }
        }

        private void lvAccountStatement_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTransaction = lvAccountStatement.SelectedItems[0];
            string transactionType = selectedTransaction.SubItems[1].Text;
            decimal transactionAmount = decimal.Parse(selectedTransaction.SubItems[2].Text);

            // Open the receipt form for the selected transaction
            ReceiptForm receiptForm = new ReceiptForm(transactionType, transactionAmount);
            receiptForm.ShowDialog();
        }
    }
}
