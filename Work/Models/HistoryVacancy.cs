using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class HistoryVacancy
{
    [Key]
    public int Id { get; set; }
    
    public virtual Employer? Employer { get; set; }
    public virtual List<Vacancy>? Vacancies { get; set; }
}