using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSimulator
{
    public partial class ChangePin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.filipenkov\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        public ChangePin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newPinTb.Text) || string.IsNullOrWhiteSpace(confirmPinTb.Text))
            {
                MessageBox.Show("Enter and confirm new PIN");
            }
            else if (newPinTb.Text != confirmPinTb.Text)
            {
                MessageBox.Show("PIN1 and PIN2 are different");
            }
            else
            {
                string Acc = Login.AccNumber;
                try
                {
                    connection.Open();
                    string query = $"update AccountTbl set PIN = {newPinTb.Text} where AccNum = '{Acc}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("PIN successfully updated");
                    connection.Close();
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
