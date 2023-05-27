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
    public partial class Deposit : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.filipenkov\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        int oldBalance, newBalance;
        string Acc = Login.AccNumber;

        public Deposit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(amountTb.Text) || Convert.ToInt32(amountTb.Text) <= 0)
            {
                MessageBox.Show("Enter amount to deposit");
            }
            else
            {
                newBalance = oldBalance + Convert.ToInt32(amountTb.Text);
                try
                {
                    connection.Open();
                    string query = $"update AccountTbl set Balance = {newBalance} where AccNum = '{Acc}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Success deposit");
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

        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void GetBalance()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select Balance from AccountTbl where AccNum = '{Acc}'", connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            connection.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddTransaction()
        {
            try
            {
                connection.Open();
                string query = $"insert into TransactionTbl values('{Acc}', 'Deposit', {amountTb.Text}, '{DateTime.Today.Date.ToString()}')";
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
