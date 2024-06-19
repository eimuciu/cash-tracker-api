using System.ComponentModel.DataAnnotations;
using cash_tracker_api.Data;
using Microsoft.EntityFrameworkCore;
using cash_tracker_api.Entities;
using Microsoft.EntityFrameworkCore.Design;
using API.Controllers;


var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddDbContext<DataContext>(opt =>
// {
//     opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
// });
// builder.Services.AddSingleton(new ContextTableName(""));

builder.Services.AddTransient<DataContextFactory>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

// app.MapGet("/", () =>
// {
    // using var scope = app.Services.CreateScope();
    // var services = scope.ServiceProvider;
    // var context = services.GetRequiredService<DataContext>();

    // DbSet<Person> per = context.Set<Person>();
    // context.Database.EnsureCreatedAsync().Wait();

    // var per1 = new Person { Id = 1, Name = "James" };
    // _context.Add(per1);

    // _context.SaveChanges();

//     return "Hello World!";
// });

app.Run();

