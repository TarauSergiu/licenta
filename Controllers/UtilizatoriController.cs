using licenta.Data;
using licenta.Models;
using Microsoft.AspNetCore.Mvc;

namespace licenta.Controllers;
// Controllers/UtilizatoriController.cs
[ApiController]
[Route("api/[controller]/[action]")]

public class UtilizatoriController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Test()
    {
        return Ok("Totul e ok!");
    }

}