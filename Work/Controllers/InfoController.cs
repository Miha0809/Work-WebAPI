using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Work.Models;
using Work.Services;

namespace Work.Controllers;

[Route("api/[controller]")]
[ApiController]
// [Authorize] // TODO: Role
public class InfoController : ControllerBase
{
    private readonly WorkDbContext _context;

    public InfoController(WorkDbContext context)
    {
        _context = context;
    }

    [HttpGet("employers")]
    public async Task<ActionResult<IEnumerable<Employer>>> Employers()
    {
        return await _context.Employers.ToListAsync();
    }

    [HttpGet("hello")]
    public async Task<ActionResult<string>> Hello()
    {
        return Ok("Hello, World");
    }

    [HttpGet("info")]
    public async Task<ActionResult> Information()
    {
        var id = HttpContext.User.FindFirstValue("Id");
        var email = HttpContext.User.FindFirstValue("Email");
        var role = HttpContext.User.FindFirstValue("Role");
        return Ok(new
        {
            Id = id,
            Email = email,
            Role = role
        });
    }
}