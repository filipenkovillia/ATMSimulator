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
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(a => a.Id);
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(t => t.Id);
            });

            modelBuilder.Entity<ATM>(entity =>
            {
                entity.HasKey(a => a.Id);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasKey(c => c.Id);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
