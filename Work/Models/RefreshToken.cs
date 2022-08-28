using Microsoft.Build.Framework;

namespace Work.Models;

public class RefreshToken
{
    public int Id { get; set; }
    
    [Required]
    public string Token { get; set; }
    
    [Required]
    public int UserId { get; set; }
}