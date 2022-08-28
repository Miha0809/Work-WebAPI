using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Street
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(64, MinimumLength = 4)]
    public string Name { get; set; }
}