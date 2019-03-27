namespace userDataManagement.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int HoursReported { get; set; }
        public int ClientId { get; set; }
    }
}