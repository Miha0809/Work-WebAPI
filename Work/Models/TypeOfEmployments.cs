using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class TypeOfEmployments
{   
    [Key]
    public int Id { get; set; }
    
    // [Required] TODO: ??
    // [StringLength(32, MinimumLength = 2)]
    // [DataType(DataType.Text)]
    public string? Name { get; set; }
}