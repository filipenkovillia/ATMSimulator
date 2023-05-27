using ATMSimulator.Model.AppDbContext;
using ATMSimulator.View.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ATMSimulator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build the configuration
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            // Create DbContextOptions
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            // Create the DbContext
            using (var dbContext = new AppDbContext(options))
            {
                // Perform migration operations
                dbContext.Database.Migrate();
            }

            // Create an instance of your main form and pass the configuration
            //MainForm mainForm = new MainForm(configuration);
            Application.Run(new LoginForm());
        }
    }
}