namespace Work.Models;

public class Employer
{
    public int Id { get; set; }
    public uint CountJobs { get; set; }
    
    public string Name { get; set; }
    public string Description { get; set; }
    public string Email { get; set; }
    public string NumberPhone { get; set; }
    
    public virtual List<Vacancy>?  Vacancies { get; set; }
}