namespace cash_tracker_api.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public string User {get; set;} = "";
        public int Amount { get; set; }
        public string Category { get; set; } = "";
        public DateTime Date { get; set; }
        public string Note { get; set; } = "";

    }
}