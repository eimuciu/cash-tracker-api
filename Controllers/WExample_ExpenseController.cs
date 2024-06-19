using cash_tracker_api.Data;
using Microsoft.AspNetCore.Mvc;
using cash_tracker_api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using System.Text.Json;

namespace API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ExpenseController : ControllerBase
{
    private readonly DataContextFactory _dbFactory;

    public ExpenseController(DataContextFactory dbFactory)
    {
        _dbFactory = dbFactory;
    }

    [HttpGet]
    public string Get()
    {
        string tableName = "expense5";

        DataContext dbContext = _dbFactory.CreateDynamicDataContext(tableName);

        try
        {

            var exists = dbContext.Set<Expense>().Count();
            Console.WriteLine(exists);

        }
        catch (Exception err)
        {
            if (err.Message == $"SQLite Error 1: 'no such table: {tableName}'.")
            {
                Console.WriteLine("The Message is real !!!");

                SqliteParameter para = new SqliteParameter("@table", tableName);

                dbContext.Database.ExecuteSqlRawAsync(@"CREATE TABLE @table (Id INTEGER PRIMARY KEY AUTOINCREMENT, Amount INTEGER NOT NULL)", para);


            }
        }

        return "Created";






        // dbContext.Expense.Add(new Expense { });
        // int recordsAffected = dbContext.SaveChanges();
        // Console.WriteLine(
        //   "Saved {0} entities to the database, press any key to exit.",
        //   recordsAffected);
    }
}
