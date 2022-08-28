using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class Applicant
{
    [Key]
    public int Id { get; set; }
    
    [StringLength(128, MinimumLength = 5)]
    [DataType(DataType.Text)]
    public string FullName { get; set; }
    
    [StringLength(32, MinimumLength = 5)]
    [DataType(DataType.Text)]
    public string NumberPhone { get; set; }
    
    [Required]
    [EmailAddress]
    [StringLength(128, MinimumLength = 10)]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    [PasswordPropertyText]
    [StringLength(128, MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    public virtual Role? Role { get; set; }
    public virtual List<Resume>? Resumes { get; set; }
}