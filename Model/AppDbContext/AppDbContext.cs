using ATMSimulator.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ATMSimulator.Model.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Entities.Account> Accounts { get; set; }
        public DbSet<ATM> ATMs { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DefaultConnection");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Account entity
            modelBuilder.Entity<Entities.Account>(entity =>
            {
                entity.HasKey(a => a.Id);
                // Add any additional configuration for the Account entity
            });

            // Configure Transaction entity
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(t => t.Id);
                // Add any additional configuration for the Transaction entity
            });

            // Configure ATM entity
            modelBuilder.Entity<ATM>(entity =>
            {
                entity.HasKey(a => a.Id);
                // Add any additional configuration for the ATM entity
            });

            // Configure Customer entity
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);
                // Add any additional configuration for the Customer entity
            });

            // Configure Card entity
            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(c => c.Id);
                // Add any additional configuration for the Card entity
            });

            // Add any additional configuration or relationships between entities

            base.OnModelCreating(modelBuilder);
        }
    }
}
