namespace Work.Models;

public class Vacancy
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual Category? Categories { get; set; }
    public virtual TypeOfEmployments? TypeOfEmployments { get; set; }
    public virtual Experience? Experiences { get; set; }
    public virtual VacancyIsSuitable? VacancyIsSuitable { get; set; }
    public virtual City? City { get; set; }
    public virtual Salary? Salary { get; set; }
    public virtual Education? Education { get; set; }
}