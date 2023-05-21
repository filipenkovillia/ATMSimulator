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
    public partial class Balance : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\i.filipenkov\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Balance()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            accNumberLb.Text = Home.AccNumber;
            GetBalance();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetBalance()
        {
            connection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"select Balance from AccountTbl where AccNum = '{accNumberLb.Text}'", connection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            balanceLb.Text = $"Rs {dt.Rows[0][0].ToString()}";
            connection.Close();
        }
    }
}
