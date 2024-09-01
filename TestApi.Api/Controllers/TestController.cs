using Microsoft.AspNetCore.Mvc;

namespace TestApi.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase {
    [HttpGet("ok")]
    public IActionResult Test() {
        return Ok("Que onda TPI ATR");
    }
}