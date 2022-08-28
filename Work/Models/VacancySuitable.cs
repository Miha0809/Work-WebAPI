using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class VacancySuitable
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength()]
    public string Name { get; set; }
}