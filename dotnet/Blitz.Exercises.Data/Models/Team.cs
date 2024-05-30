namespace Blitz.Exercises.Data.Models;

public class Team : Entity
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Nickname { get; set; }
    
    public virtual ICollection<Contract> Contracts { get; set; }
}