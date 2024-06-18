using Microsoft.EntityFrameworkCore;
using cash_tracker_api.Entities;

namespace cash_tracker_api.Data
{
    public class DataContext : DbContext
    {

        private readonly string _tableName;
        public DataContext(DbContextOptions options, ContextTableName tableName) : base(options)
        {
            _tableName = tableName.TableName;
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().ToTable(_tableName);
        }

    }
}