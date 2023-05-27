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
    public partial class FastCash : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.filipenkov\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Acc = Login.AccNumber;
        int balance;

        public FastCash()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void FastCash_Load(object sender, EventArgs e)
        {
            GetBalance();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Withdraw(100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Withdraw(500);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Withdraw(1000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Withdraw(2000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Withdraw(5000);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Withdraw(10000);
        }

        private void Withdraw(int amount)
        {
            if (balance < amount)
            {
                MessageBox.Show("Balance can not be negative");
            }
            else
            {
                try
                {
                    int newBalance = balance - amount;
                    connection.Open();
                    string query = $"update AccountTbl set Balance = {newBalance} where AccNum = '{Acc}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Success withdraw");
                    connection.Close();
                    AddTransaction(amount);
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

        private void AddTransaction(int amount)
        {
            try
            {
                connection.Open();
                string query = $"insert into TransactionTbl values('{Acc}', 'Withdraw', {amount}, '{DateTime.Today.Date.ToString()}')";
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
