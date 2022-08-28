using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Work.Models;
using Work.Services;

namespace Work.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VacancyController : ControllerBase
{
    private readonly WorkDbContext _context;

    public VacancyController(WorkDbContext context)
    {
        _context = context;
    }

    [HttpGet("vacancies")]
    public async Task<IActionResult> GetVacancies()
    {
        return Ok(await _context.Vacancies.ToListAsync());
    }

    [HttpGet("vacancies/{id}")]
    public async Task<IActionResult> GetVacancie(int id)
    {
        return Ok(await _context.Vacancies.FindAsync(id));
    }

    [Authorize(Roles = "Employer")]
    [HttpPost("vacancy")]
    // [ValidateAntiForgeryToken] TODO: Check
    public async Task<IActionResult> PostVacancy([FromBody] Vacancy vacancy)
    {
        if (vacancy == null || !ModelState.IsValid)
        {
            return BadRequest();
        }
        
        vacancy.Employer = await _context.Employers.FirstOrDefaultAsync(user => user.Email.Equals(vacancy.Employer.Email));
        
        await _context.Vacancies.AddAsync(vacancy);
        await _context.SaveChangesAsync();

        return Ok(vacancy);
    }

    [Authorize(Roles = "Employer")]
    [HttpPut("vacancy/{id}")]
    public async Task<IActionResult> PutVacancy(int id, [FromBody] Vacancy vacancy)
    {
        if (vacancy == null || !ModelState.IsValid)
        {
            return BadRequest();
        }

        var vacancyFind = await _context.Vacancies.FindAsync(id);

        _context.Vacancies.Remove(vacancyFind);
        await _context.Vacancies.AddAsync(vacancy);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [Authorize(Roles = "Employer")]
    [HttpDelete("vacancy/{id}")]
    public async Task<IActionResult> DeleteVacancy(int id)
    {
        int.TryParse(HttpContext.User.FindFirstValue("Id"), out var userId);
        var vacancy = await _context.Vacancies.FindAsync(id);
        var user = await _context.Employers.FindAsync(userId);
        var historyVacancy = new HistoryVacancy()
        {
            Employer = user,
            Vacancies = new List<Vacancy> { vacancy }
        };
        _context.Vacancies.Remove(vacancy);
        await _context.HistoryVacancies.AddAsync(historyVacancy);
        await _context.SaveChangesAsync();
        
        return Ok();
    }
}
