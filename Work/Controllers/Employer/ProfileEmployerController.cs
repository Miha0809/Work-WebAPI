using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Work.Services;

namespace Work.Controllers.Employer;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Employer")]
public class ProfileEmployerController : ControllerBase
{
    private readonly WorkDbContext _context;

    public ProfileEmployerController(WorkDbContext context)
    {
        _context = context;
    }

    [HttpGet("profile")]
    public async Task<IActionResult> Profile()
    {
        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        var employer = await _context.Employers.FirstOrDefaultAsync(user => user.Id.Equals(userId));

        return Ok(employer);
    }

    [HttpPut("profile/setting")]
    public async Task<IActionResult> PutProfile([FromBody] Models.Employer employer)
    {
        if (!ModelState.IsValid || employer == null)
        {
            return BadRequest();
        }

        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        _context.Employers.Remove(await _context.Employers.FindAsync(userId));
        await _context.Employers.AddAsync(employer);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("profile/delete")]
    public async Task<IActionResult> DeleteProfile()
    {
        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        var employer = await _context.Employers.FindAsync(userId);
        _context.Employers.Remove(employer);

        return Ok();
    }

    // TODO: Create history my vacancies
    [HttpGet("profile/histoty/vacancies")]
    public async Task<IActionResult> GetHistoryVacancies()
    {
        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        return Ok(_context.HistoryVacancies.Select(o => o.Employer.Id.Equals(userId)).ToListAsync());
    }
}