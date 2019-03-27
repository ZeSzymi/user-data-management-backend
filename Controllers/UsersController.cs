using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace userDataManagement.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet("")]
        public async Task<IActionResult> GetUsers() {
            return Ok("Users");
        }
    }
}
    