namespace userDataManagement.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HoursReported { get; set; }
        public int? ClientId { get; set; }
        public int UserId { get; set; }
    }
}