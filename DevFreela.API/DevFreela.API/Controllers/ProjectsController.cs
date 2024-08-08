using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    public class ProjectsController : ControllerBase
    {
        [Route("api/Projects")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
