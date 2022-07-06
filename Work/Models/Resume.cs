namespace Work.Models;

public class Resume
{
    public int Id { get; set; }
    
    public Category Category { get; set; }
    public City City { get; set; }
    public Education Education { get; set; }
    public Experience Experience { get; set; }
    public Salary Salary { get; set; }
    public TypeOfEmployments TypeOfEmployments { get; set; }
    public VacancyIsSuitable VacancyIsSuitable { get; set; }
}