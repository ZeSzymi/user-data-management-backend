namespace userDataManagement.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int HoursWorked { get; set; }
        public string TypeOfWork { get; set; }
    }
}