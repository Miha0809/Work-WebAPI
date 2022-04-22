using Microsoft.EntityFrameworkCore;
using Work.Models;

namespace Work.Services;

public class WorkDbContext : DbContext
{
    public WorkDbContext(DbContextOptions<WorkDbContext> options) : base(options)
    {
    }

    public virtual List<Category> Categories { get; set; }
    public virtual List<City> Cities { get; set; }
    public virtual List<Employer> Employers { get; set; }
    public virtual List<Vacancy> Vacancies { get; set; }
}