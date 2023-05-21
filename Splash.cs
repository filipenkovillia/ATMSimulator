namespace ATMSimulator
{
    public partial class Splash : Form
    {
        int starting = 0;
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
            progressBar.Value = starting;
            percentageLb.Text = starting + "%";
            if(progressBar.Value >= 100)
            {
                progressBar.Value = 0;
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}