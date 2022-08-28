using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Work.Services;

namespace Work.Controllers.Applicant;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "Applicant")]
public class ProfileApplicantController : ControllerBase
{
    private readonly WorkDbContext _context;
    
    public ProfileApplicantController(WorkDbContext context)
    {
        _context = context;
    }

    [HttpGet("profile")]
    public async Task<IActionResult> Profile()
    {
        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        var user = await _context.Applicants.FirstOrDefaultAsync(user => user.Id.Equals(userId));
        
        return Ok(user);
    }

    [HttpPut("profile/setting")]
    public async Task<IActionResult> PutProfile([FromBody] Models.Applicant applicant)
    {
        if (!ModelState.IsValid || applicant == null)
        {
            return BadRequest();
        }

        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        _context.Applicants.Remove(await _context.Applicants.FindAsync(userId));
        await _context.Applicants.AddAsync(applicant);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("profile/delete")]
    public async Task<IActionResult> DeleteProfile()
    {
        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        var user = await _context.Employers.FindAsync(userId);
        _context.Employers.Remove(user);

        return Ok();
    }
}