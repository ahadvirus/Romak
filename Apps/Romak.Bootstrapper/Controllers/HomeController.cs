using Microsoft.AspNetCore.Mvc;

namespace Romak.Bootstrapper.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}
