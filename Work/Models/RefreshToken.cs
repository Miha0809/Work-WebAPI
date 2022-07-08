using System.ComponentModel.DataAnnotations;

namespace Work.Models;

public class RefreshToken
{
    public int Id { get; set; }
    
    [Required]
    [DataType(DataType.MultilineText)]
    public string Token { get; set; }
    
    [Required]
    public int UserId { get; set; }
}