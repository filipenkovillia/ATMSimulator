﻿using ATMSimulator.Controller;
using ATMSimulator.Model.Enum;
using ATMSimulator.Session;

namespace ATMSimulator.View.Forms
{
    public partial class AccountStatementForm : Form
    {
        private readonly AccountStatementController _accountStatementController;

        public AccountStatementForm()
        {
            InitializeComponent();
            _accountStatementController = new AccountStatementController(UserSession.Instance.AccountId, UserSession.Instance.CardId);
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

            dataGridViewTransactions.AutoGenerateColumns = false;

            dataGridViewTransactions.Columns.Add("TransactionDate", "Transaction Date");
            dataGridViewTransactions.Columns.Add("Amount", "Amount");

            dataGridViewTransactions.Columns["TransactionDate"].DataPropertyName = "TransactionDate";
            dataGridViewTransactions.Columns["Amount"].DataPropertyName = "Amount";

            dataGridViewTransactions.DataSource = accountStatement;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            var selectedTransaction = dataGridViewTransactions.CurrentRow;

            Guid transactionId = _accountStatementController.GetTransactionId(selectedTransaction.Cells["Id"].Value.ToString());
            if (transactionId != Guid.Empty)
            {
                MessageBox.Show(_accountStatementController.GetReceiptText(transactionId));
            }
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            _accountStatementController.ExportAccountStatementToFile(ExportFormat.PDF);
        }

        private void btnExportXlsx_Click(object sender, EventArgs e)
        {
            _accountStatementController.ExportAccountStatementToFile(ExportFormat.XLSX);
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            _accountStatementController.ExportAccountStatementToFile(ExportFormat.CSV);
        }
    }
}
