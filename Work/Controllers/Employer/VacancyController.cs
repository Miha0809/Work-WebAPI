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

        vacancy.Employer =
            await _context.Employers.FirstOrDefaultAsync(user =>
                user.Email.Equals(HttpContext.User.FindFirstValue("Email")));
        vacancy.Category =
            await _context.Categories.FirstOrDefaultAsync(category =>
                category.Id.Equals(vacancy.Category!.Id));
        vacancy.TypeOfEmployments =
            await _context.TypeOfEmployments.FirstOrDefaultAsync(type =>
                type.Id.Equals(vacancy.TypeOfEmployments!.Id));
        vacancy.Experience =
            await _context.Experiences.FirstOrDefaultAsync(experience =>
                experience.Id.Equals(vacancy.Experience!.Id));
        vacancy.VacancySuitable =
            await _context.VacancySuitables.FirstOrDefaultAsync(suitable =>
                suitable.Id.Equals(vacancy.VacancySuitable!.Id));
        vacancy.Education =
            await _context.Educations.FirstOrDefaultAsync(education =>
                education.Id.Equals(vacancy.Education!.Id));

        if (vacancy.Salary?.Comment != null)
        {
            vacancy.Salary =
                await _context.Salaries.FirstOrDefaultAsync(salary =>
                    salary.Comment!.Equals(vacancy.Salary.Comment));
        }
        
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
            Vacancies = new List<Vacancy> {vacancy}
        };
        _context.Vacancies.Remove(vacancy);
        await _context.HistoryVacancies.AddAsync(historyVacancy);
        await _context.SaveChangesAsync();

        return Ok(historyVacancy);
    }
}