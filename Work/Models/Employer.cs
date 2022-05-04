using Work.Models.Interfaces;

namespace Work.Models;

public class Employer : IUser
{
    public int Id { get; set; }
    public uint CountJobs { get; set; }
    
    public string NameCompany { get; set; }
    public string FullName { get; set; }
    public string NumberPhone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Description { get; set; }
    
    public virtual List<Vacancy>?  Vacancies { get; set; }
}