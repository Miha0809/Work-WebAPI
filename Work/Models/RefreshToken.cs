namespace Work.Models;

public class RefreshToken
{
    public int Id { get; set; }
    
    public string Token { get; set; }
    
    public int UserId { get; set; }
}