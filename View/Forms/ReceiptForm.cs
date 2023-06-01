using ATMSimulator.Controller;
using ATMSimulator.Model.Entities;
using ATMSimulator.Model.Enum;
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
    public partial class ReceiptForm : Form
    {
        private readonly ReceiptController _receiptController;

        public ReceiptForm(Guid transactionId)
        {
            InitializeComponent();
            _receiptController = new ReceiptController(transactionId);
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Close();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            var transaction = _receiptController.GetTransaction();
            lbTransactionType.Text = transaction.TransactionType.ToString();
            lbAmount.Text = $"${transaction.Amount}";

            PrintReceipt();
        }

        private void PrintReceipt()
        {
            var transaction = _receiptController.GetTransaction();

            string receiptText = $"Transaction Type: {transaction.TransactionType}\n" +
                $"Transaction Amount: ${transaction.Amount}\n\n" +
                $"Receipt printed successfully!";

            MessageBox.Show(receiptText, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
