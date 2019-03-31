using System.Collections.Generic;
using userDataManagement.Models;

namespace userDataManagement.Dtos
{
    public class JobDto : Job
    {
        public UserDto User { get; set; }
    }
}