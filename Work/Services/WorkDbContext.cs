using Microsoft.EntityFrameworkCore;
using Work.Models;

namespace Work.Services;

public class WorkDbContext : DbContext
{
    public WorkDbContext(DbContextOptions<WorkDbContext> options) : base(options) {}
    
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<City> Cities { get; set; }
    public virtual DbSet<Employer> Employers { get; set; }
    public virtual DbSet<Applicant> Applicants { get; set; }
    public virtual DbSet<Vacancy> Vacancies { get; set; }
    public virtual DbSet<Education> Educations { get; set; }
    public virtual DbSet<Experience> Experiences { get; set; }
    public virtual DbSet<TypeOfEmployments> TypeOfEmployments { get; set; }
    public virtual DbSet<VacancyIsSuitable> VacancyIsSuitables { get; set; }
    public virtual DbSet<Resume> Resumes { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
}