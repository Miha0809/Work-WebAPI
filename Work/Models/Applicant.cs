namespace Work.Models;

public class Applicant
{
    public int Id { get; set; }
    
    public string FullName { get; set; }
    public string NumberPhone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    
    public Role? Role { get; set; }
    public List<Resume>? Resumes { get; set; }
}