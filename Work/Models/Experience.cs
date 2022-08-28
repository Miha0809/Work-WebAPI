using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Experience
{
    [Key]
    public int Id { get; set; }
    
    // [Required] TODO: ??
    // [StringLength(32, MinimumLength = 4)]
    public string? Name { get; set; }
}