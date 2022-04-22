namespace Work.Models;

public class City
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public virtual Street? Street { get; set; }
}