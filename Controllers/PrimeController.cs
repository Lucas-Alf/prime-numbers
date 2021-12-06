using Microsoft.AspNetCore.Mvc;
using RSD_II_API.Services;

namespace RSD_2_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrimeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new PrimeNumberService().GetNumbers());
        }
    }
}
