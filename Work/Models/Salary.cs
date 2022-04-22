namespace Work.Models;

public class Salary
{
    public int Id { get; set; }

    public ulong Min { get; set; }
    public ulong Max { get; set; }
    
    public string? Comment { get; set; }
}