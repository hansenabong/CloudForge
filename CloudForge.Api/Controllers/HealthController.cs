using Microsoft.AspNetCore.Mvc;

namespace CloudForge.Api.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult GetHealth()
    {
        return Ok(new
        {
            Status = "healthy",
            Service = "CloudForge API",
            Version = "0.1"
        });
    }
}