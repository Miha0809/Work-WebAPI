using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Salary
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Range(100, ulong.MaxValue - 1, ErrorMessage = "Minimum < 100")]
    [DataType(DataType.Currency)]
    public ulong Min { get; set; }
    
    [Required]
    [Range(100, ulong.MaxValue)]
    [DataType(DataType.Currency)]
    public ulong Max { get; set; }
    
    [StringLength(32, MinimumLength = 4)]
    [DataType(DataType.Text)]
    public string? Comment { get; set; }
}