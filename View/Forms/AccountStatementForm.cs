using ATMSimulator.Controller;
using ATMSimulator.Session;

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

            dataGridViewTransactions.AutoGenerateColumns = false;


            dataGridViewTransactions.Columns.Add("Id", "Id");
            dataGridViewTransactions.Columns.Add("TransactionDate", "Transaction Date");
            dataGridViewTransactions.Columns.Add("Amount", "Amount");

            dataGridViewTransactions.Columns["Id"].DataPropertyName = "Id";
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
    }
}
