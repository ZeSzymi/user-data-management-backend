using System.Collections.Generic;
using userDataManagement.Models;

namespace userDataManagement.ModelsDb
{
    public class UserJobDb : UserJob
    {
        public User User { get; set; }
        public Job Job { get; set; }
    }
}