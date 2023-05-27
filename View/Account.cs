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
    public partial class Account : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.filipenkov\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        
        public Account()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int balance = 0;
            if (string.IsNullOrWhiteSpace(accNumTb.Text) 
                || string.IsNullOrWhiteSpace(nameTb.Text) 
                || string.IsNullOrWhiteSpace(faNameTb.Text) 
                || string.IsNullOrWhiteSpace(addressTb.Text) 
                || string.IsNullOrWhiteSpace(phoneTb.Text) 
                || string.IsNullOrWhiteSpace(pinTb.Text) 
                || string.IsNullOrWhiteSpace(educationCb.Text) 
                || string.IsNullOrWhiteSpace(occupationTb.Text))
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = $"insert into " +
                        $"AccountTbl(AccNum, Name, FaName, Dob, Phone, Address, Education, Occupation, Balance, PIN) " +
                        $"values('{accNumTb.Text}', '{nameTb.Text}', '{faNameTb.Text}', '{dobDate.Text}', '{phoneTb.Text}', '{addressTb.Text}', '{educationCb.Text}', '{occupationTb.Text}', {balance}, {pinTb.Text})";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
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

        private void label13_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
