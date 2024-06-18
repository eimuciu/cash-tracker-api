using cash_tracker_api.Data;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using cash_tracker_api.Entities;

namespace API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly DataContextFactory _dbFactory;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, DataContextFactory dbFactory)
    {
        _logger = logger;
        _dbFactory = dbFactory;
    }

    [HttpGet]
    public void Get()
    {
        DataContext dbContext = _dbFactory.CreateDynamicDataContext("table2");

        dbContext.Persons.Add(new Person { Id = 7, Name = "Cat" });
        int recordsAffected = dbContext.SaveChanges();
        Console.WriteLine(
          "Saved {0} entities to the database, press any key to exit.",
          recordsAffected);
    }
}
