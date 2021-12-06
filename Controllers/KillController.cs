using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace RSD_2_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KillController : ControllerBase
    {
        private readonly IHostApplicationLifetime _applicationLifetime;

        public KillController(IHostApplicationLifetime applicationLifetime)
        {
            _applicationLifetime = applicationLifetime;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _applicationLifetime.StopApplication();
            return Ok("Morri! xP");
        }
    }
}
