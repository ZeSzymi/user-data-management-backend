using System.Collections.Generic;
using userDataManagement.Models;

namespace userDataManagement.ModelsDb
{
    public class UserDb : User
    {
        public List<JobDb> Jobs { get; set; }
    }
}