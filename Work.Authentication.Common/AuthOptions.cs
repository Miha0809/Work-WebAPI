using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Work.Authentication.Common;

public class AuthOptions
{
    public string Issuer { get; set; } // Хто згенерував
    public string Audience { get; set; } // Для кого
    public string Secret { get; set; }
    
    public int TokenLifeTime { get; set; }

    public SymmetricSecurityKey GetSymmetricSecurityKey() => new(Encoding.ASCII.GetBytes(Secret));
}