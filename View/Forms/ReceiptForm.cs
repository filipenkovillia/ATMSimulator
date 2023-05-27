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
        private string transactionType;
        private decimal transactionAmount;

        public ReceiptForm(string type, decimal amount)
        {
            InitializeComponent();
            transactionType = type;
            transactionAmount = amount;
        }

        private void lbCancel_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            this.Hide();
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            lbTransactionType.Text = transactionType;
            lbAmount.Text = $"${transactionAmount}";

            // Print the receipt automatically when the form is loaded
            PrintReceipt();
        }

        private void PrintReceipt()
        {
            // Implement your logic to print the receipt here
            // This is just a placeholder method

            // In this example, we'll display a message box with the receipt details
            string receiptText = $"Transaction Type: {transactionType}\nTransaction Amount: ${transactionAmount}\n\nReceipt printed successfully!";
            MessageBox.Show(receiptText, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
