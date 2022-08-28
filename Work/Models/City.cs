using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class City
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(20, MinimumLength = 3)]
    public string Name { get; set; }
    
    public virtual Street? Street { get; set; }
}