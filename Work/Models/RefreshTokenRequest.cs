using Microsoft.Build.Framework;

namespace Work.Models;

public class RefreshTokenRequest
{
    [Required]
    public string RefreshToken { get; set; }
}