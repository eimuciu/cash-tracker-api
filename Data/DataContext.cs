using cash_tracker_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace cash_tracker_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Expense>().ToTable("Expenses").HasKey(x => x.Id);
            builder.Entity<Income>().ToTable("Incomes").HasKey(x => x.Id);
            builder.Entity<Budget>().ToTable("Budgets").HasKey(x => x.Id);
            builder.Entity<Setting>().ToTable("Settings").HasKey(x => x.Id);
        }

    }
}