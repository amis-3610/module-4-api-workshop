using Microsoft.AspNetCore.Mvc;

namespace Api.Workshop.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}