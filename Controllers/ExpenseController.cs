using cash_tracker_api.Data;
using Microsoft.AspNetCore.Mvc;
using cash_tracker_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace cash_tracker_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ExpenseController : ControllerBase
    {
        private readonly DataContext _context;

        public ExpenseController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string Get()
        {
            Expense expenseItem = new Expense() { User = "55", Amount = 25, Category = "food", Date = DateTime.Now, Note = "pirkau maisto" };

            // _context.Expenses.Add(expenseItem);
            // _context.SaveChangesAsync();

            // _context.Expenses.Where(x => x.User == "55").ExecuteDeleteAsync();
            // _context.SaveChangesAsync();

            return "Hello World";
        }

    }
}