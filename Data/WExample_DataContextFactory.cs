// using Microsoft.EntityFrameworkCore;

// namespace cash_tracker_api.Data
// {


//     public class DataContextFactory
//     {
//         private readonly IConfiguration _config;
//         public DataContextFactory(IConfiguration config)
//         {
//             _config = config;
//         }
//         public DataContext CreateDynamicDataContext(string tableName)
//         {
//             var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
//             // builder.Configuration.GetConnectionString("DefaultConnection")

//             string? connectionString = _config.GetConnectionString("DefaultConnection");
//             optionsBuilder.UseSqlite(connectionString);

//             var _context = new DataContext(optionsBuilder.Options, tableName);
//             return _context;

//             // _context.Database.ExecuteSqlRawAsync($"CREATE TABLE {tableName} (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL)");
//         }
//     }
// }