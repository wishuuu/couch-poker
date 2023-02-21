using Microsoft.AspNetCore.Mvc;

namespace CouchPoker.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BasicController : ControllerBase
{
    [HttpGet]
    public IActionResult Ping()
    {
        return Ok("Pong");
    }
}