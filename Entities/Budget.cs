namespace cash_tracker_api.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public string Period { get; set; } = "";
        public string Data { get; set; } = "";
    }
}