using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Resume
{
    [Key]
    public int Id { get; set; }

    public virtual Applicant? Applicant { get; set; }
    public virtual Category? Category { get; set; }
    public virtual City? City { get; set; }
    public virtual Education? Education { get; set; }
    public virtual Experience? Experience { get; set; }
    public virtual Salary? Salary { get; set; }
    public virtual TypeOfEmployments? TypeOfEmployments { get; set; }
    public virtual VacancySuitable? VacancySuitable { get; set; }
    
    [DataType(DataType.DateTime)]
    public virtual DateTime DateTime { get; set; } = DateTime.Now;
}