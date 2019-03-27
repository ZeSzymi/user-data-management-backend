using System.Collections.Generic;
using userDataManagement.Models;

namespace userDataManagement.ModelsDb
{
    public class JobDb : Job
    {
        public ClientDb Client { get; set; }
        public List<UserJobDb> UserJob { get; set; }
    }
}