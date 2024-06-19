using Microsoft.EntityFrameworkCore;
using cash_tracker_api.Entities;

namespace cash_tracker_api.Data
{
    public class DataContext : DbContext
    {

        private readonly string _tableName;
        public DataContext(DbContextOptions options, string tableName) : base(options)
        {
            _tableName = tableName;
        }

        public DbSet<Expense> Expense { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Expense>().ToTable(_tableName).HasKey(x => x.Id);
        }

    }
}