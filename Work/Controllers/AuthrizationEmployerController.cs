using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Work.Authentication.Common;
using Work.Models;
using Work.Services;

namespace Work.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthrizationEmployerController : Controller
{
    private readonly WorkDbContext _context;
    private readonly IOptions<AuthOptions> _authenticationOptions;

    public AuthrizationEmployerController(IOptions<AuthOptions> authenticationOptions, WorkDbContext context)
    {
        _authenticationOptions = authenticationOptions;
        _context = context;
    }

    [Route("login")]
    [HttpPost]
    public async Task<ActionResult<SignIn>> Login([FromBody] SignIn signIn)
    {
        var user = await _context.Employers.FirstOrDefaultAsync(user => user.Email.Equals(signIn.Email));
        
        if (user != null &&
            Hash.VerifyHash(signIn.Password, Hash.GetHash(signIn.Password)))
        {
            var token = GenerateJWT(user);

            return Ok(new
            {
                access_token = token
            });
        }

        return BadRequest(new {message = "Username or password is bad"});
    }

    private string GenerateJWT(Employer employer)
    {
        try
        {
            var authParams = _authenticationOptions.Value;
            var securityKey = authParams.GetSymmetricSecurityKey();
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);
            var claims = new List<Claim>()
            {
                new(JwtRegisteredClaimNames.Email, employer.Email)
            };
            var token = new JwtSecurityToken(
                authParams.Issuer,
                authParams.Audience,
                claims,
                DateTime.Now.AddSeconds(authParams.TokenLifeTime),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}
