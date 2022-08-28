using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Vacancy
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(32, MinimumLength = 5)]
    [DataType(DataType.Text)]
    public string Title { get; set; }
    
    [Required]
    [StringLength(512, MinimumLength = 5)] // TODO: set minimun 32
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }
    
    public virtual Employer? Employer { get; set; }
    public virtual Category? Category { get; set; }
    public virtual TypeOfEmployments? TypeOfEmployments { get; set; }
    public virtual Experience? Experience { get; set; }
    public virtual VacancySuitable? VacancySuitable { get; set; }
    public virtual City? City { get; set; }
    public virtual Salary? Salary { get; set; }
    public virtual Education? Education { get; set; }
}