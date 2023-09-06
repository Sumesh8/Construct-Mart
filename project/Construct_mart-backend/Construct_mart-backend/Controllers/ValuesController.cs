using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Construct_mart_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult UsersGet()
        {
            var users = new string[] { "sumesh", "akalanka", "viraji" };
            return Ok(users);
        }

        [HttpPost]
        public IActionResult UsersPost()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UsersUpdate()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult UsersDelete()
        {
            var somthingWentWrong = true;
            if (somthingWentWrong) return BadRequest();
            return Ok();
        }
    }
}
