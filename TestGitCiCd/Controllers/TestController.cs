using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestGitCiCd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("peyman");
        }
    }
}
