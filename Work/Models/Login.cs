using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Login
{
    [Required]
    [EmailAddress]
    [DataType(DataType.EmailAddress)]
    [StringLength(256, MinimumLength = 8)]
    public string Email { get; set; }
    
    [Required]
    [DataType(DataType.Password)]
    [StringLength(256, MinimumLength = 6)]
    public string Password { get; set; }
}