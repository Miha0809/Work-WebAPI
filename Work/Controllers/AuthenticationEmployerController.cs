using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Work.Models;
using Work.Services;

namespace Work.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationEmployerController : ControllerBase
{
    private readonly WorkDbContext _context;

    public AuthenticationEmployerController(WorkDbContext context)
    {
        _context = context;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(Employer employer)
    {
        if (employer == null || !ModelState.IsValid)
        {
            return BadRequest();
        }

        employer.Password = Hash.GetHash(employer.Password);
        employer.Role = await _context.Roles.FirstOrDefaultAsync(role => role.Name.Equals("Employer"));

        await _context.Employers.AddAsync(employer);
        await _context.SaveChangesAsync();

        // return CreatedAtAction("GetEmployer", "Employer", new {id = employer.Id}, employer);
        return Ok(employer);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Login login)
    {
        var user = await _context.Employers.FirstOrDefaultAsync(user =>
            user.Email.Equals(login.Email) && Hash.GetHash(login.Password) == user.Password);

        if (user == null || !Hash.VerifyHash(login.Password, Hash.GetHash(login.Password)) || !ModelState.IsValid)
        {
            return BadRequest();
        }

        // TODO: При реєстрації роль встанюється, а при логіні роль null
        user.Role = await _context.Roles.FirstOrDefaultAsync(role => role.Name.Equals("Employer"));
        
        var accessToken = GenerateAccessToken(user);
        var refreshToken = GenerateRefreshToken();
        var refreshTokenDTO = new RefreshToken()
        {
            Token = refreshToken,
            UserId = user.Id
        };

        return Ok(new
        {
            access_tone = accessToken,
            refresh_token = refreshToken
        });
    }

    [HttpPost("refresh")]
    public async Task<IActionResult> Refresh([FromBody] RefreshTokenRequest refresh)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }
    
        var isValid = Validate(refresh.RefreshToken);
        var refreshToken = await _context.RefreshTokens.FirstOrDefaultAsync(token => token.Token.Equals(refresh));
        var user = await _context.Employers.FindAsync(refreshToken.UserId);
    
        _context.RefreshTokens.Remove(refreshToken);
        await _context.SaveChangesAsync();
        
        if (!isValid || refreshToken == null || user == null)
        {
            return BadRequest();
        }
    
        var accessToken = GenerateAccessToken(user);
        var refreshToken2 = GenerateRefreshToken();
        var refreshTokenDTO = new RefreshToken()
        {
            Token = refreshToken2,
            UserId = user.Id
        };
        
        await _context.RefreshTokens.AddAsync(refreshTokenDTO);
        await _context.SaveChangesAsync();
    
        return Ok(new
        {
            access_tone = accessToken,
            refresh_token = refreshToken
        });
    }

    private string GenerateAccessToken(Employer employer)
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("ACCESS_SECRET_KEY")));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);
        var claims = new List<Claim>
        {
            new("Id", employer.Id.ToString()),
            new("Email", employer.Email),
            new("Role", employer.Role.Name)
        };
        var issuer = Environment.GetEnvironmentVariable("ISSUER") ?? string.Empty;
        var audience = Environment.GetEnvironmentVariable("AUDIENCE") ?? string.Empty;
        var minutes = int.Parse(Environment.GetEnvironmentVariable("ACCESS_TIME_LIFE_KAY_MIN") ?? string.Empty);
        var token = new JwtSecurityToken(issuer: issuer,
                                         audience: audience,
                                         claims: claims,
                                         notBefore: DateTime.UtcNow,
                                         expires: DateTime.Now.AddMinutes(minutes),
                                         signingCredentials: credentials);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
    
    private string GenerateRefreshToken()
    {
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("REFRESH_SECRET_KEY")));
        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);
        var issuer = Environment.GetEnvironmentVariable("ISSUER") ?? string.Empty;
        var audience = Environment.GetEnvironmentVariable("AUDIENCE") ?? string.Empty;
        var minutes = int.Parse(Environment.GetEnvironmentVariable("REFRESH_TIME_LIFE_KAY_MIN") ?? string.Empty);
        var token = new JwtSecurityToken(issuer: issuer,
            audience: audience,
            notBefore: DateTime.UtcNow,
            expires: DateTime.Now.AddMinutes(minutes),
            signingCredentials: credentials);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private bool Validate(string refresh)
    {
        var tokenValidationParameters = new TokenValidationParameters()
        {
            IssuerSigningKey =
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("REFRESH_SECRET_KEY"))),
            ValidIssuer = Environment.GetEnvironmentVariable("ISSUER"),
            ValidAudience = Environment.GetEnvironmentVariable("AUDIENCE"),
            ValidateIssuerSigningKey = true,
            ValidateIssuer = true,
            ValidateAudience = true,
            ClockSkew = TimeSpan.Zero
        };
        var token = new JwtSecurityTokenHandler();
    
        try
        {
            token.ValidateToken(refresh, tokenValidationParameters, out SecurityToken validated);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}
