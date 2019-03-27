using System.Collections.Generic;
using userDataManagement.Models;

namespace userDataManagement.ModelsDb
{
    public class UserDb : User
    {
        public List<UserJobDb> UserJob { get; set; }
    }
}