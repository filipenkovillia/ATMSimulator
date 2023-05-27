using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class Withdraw : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.filipenkov\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int balance;
        int newBalance;

        public Withdraw()
        {
            InitializeComponent();
        }

        private void GetBalance()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select Balance from AccountTbl where AccNum = '{Acc}'", connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            balanceLb.Text = $"Rs {dt.Rows[0][0].ToString()}";
            balance = Convert.ToInt32(dt.Rows[0][0].ToString());
            connection.Close();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(withdrawTb.Text))
            {
                MessageBox.Show("Missing information");
            }
            else if(Convert.ToInt32(withdrawTb.Text) <= 0)
            {
                MessageBox.Show("Enter a valid amount");
            }
            else if (Convert.ToInt32(withdrawTb.Text) > balance)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                try
                {
                    newBalance = balance - Convert.ToInt32(withdrawTb.Text);
                    connection.Open();
                    string query = $"update AccountTbl set Balance = {newBalance} where AccNum = '{Acc}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Success withdraw");
                    connection.Close();
                    AddTransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AddTransaction()
        {
            try
            {
                connection.Open();
                string query = $"insert into TransactionTbl values('{Acc}', 'Withdraw', {withdrawTb.Text}, '{DateTime.Today.Date.ToString()}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                //MessageBox.Show("Success deposit");
                connection.Close();
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
