using Microsoft.AspNetCore.Mvc;

namespace TeamGitPractice.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetMembers()
    {
        var members = new[]
        {
            "Juliana Arenas Arias",
            "Juan Andres Ramirez Castañeda",
            "Heyner Mena Campaña",
            "Camilo Ospina Hernández",
            "Oscar Alexis Pineda Henao"
        };

        return Ok(members);
    }
    [HttpGet("count")]
    public IActionResult GetCount()
    {
        return Ok(new { total = 5 });
    }
}