using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class VacancySuitable
{
    [Key]
    public int Id { get; set; }
    
    // [Required] TODO: ??
    // [StringLength(32, MinimumLength = 4)]
    // [DataType(DataType.Text)]
    public string? Name { get; set; }
}