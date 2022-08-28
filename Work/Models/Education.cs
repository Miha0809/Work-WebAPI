using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Education
{
    [Key]
    public int Id { get; set; }
    
    // [Required] TODO: ??
    // [StringLength(64, MinimumLength = 4)]
    // [DataType(DataType.Text)]
    public string? Name { get; set; }
}