using Work.Models.Enums;

namespace Work.Models;

public class Vacancy
{
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    
    public virtual List<Category> Categories { get; set; }
    public virtual List<TypeOfEmployments> TypeOfEmployments { get; set; }
    public virtual List<Experience> Experiences { get; set; }
    public virtual List<VacancyIsSuitableFor>? VacancyIsSuitableFors { get; set; }

    public virtual City City { get; set; }
    public virtual Salary? Salary { get; set; }
    public virtual Education Education { get; set; } = Education.DoesNotMatter;
}