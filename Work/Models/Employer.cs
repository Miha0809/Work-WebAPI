using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Work.Models;

public class Employer
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [IntegerValidator(MinValue = 1)]
    [DataType(DataType.Currency)]
    public uint CountJobs { get; set; }
    
    [Required]
    [StringLength(128, MinimumLength = 2)]
    [DataType(DataType.Text)]
    public string NameCompany { get; set; }
    
    [Required]
    [StringLength(128, MinimumLength = 5)]
    [DataType(DataType.Text)]
    public string FullName { get; set; }
    
    [Required]
    [StringLength(32, MinimumLength = 5)]
    [DataType(DataType.Text)]
    public string NumberPhone { get; set; }
    
    [Required]
    [EmailAddress]
    [StringLength(128, MinimumLength = 10)]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    [Required]
    [PasswordPropertyText]
    [StringLength(128, MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Required]
    [StringLength(512, MinimumLength = 10)]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }
    
    
    public virtual Role? Role { get; set; }
    public virtual List<Vacancy>?  Vacancies { get; set; }
}