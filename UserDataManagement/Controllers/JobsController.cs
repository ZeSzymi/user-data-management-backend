using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace userDataManagement.Controllers
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        [HttpGet("")]
        public async Task<IActionResult> GetJobs() {
            return Ok("Jobs");
        }
    }
}