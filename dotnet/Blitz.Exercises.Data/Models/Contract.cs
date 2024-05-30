namespace Blitz.Exercises.Data.Models;

public class Contract : Entity
{
    public long Id { get; set; }
    public DateTime JoinDate { get; set; }
    public DateTime? LeaveDate { get; set; }
    
    public long TeamId { get; set; }
    public long PlayerId { get; set; }

    public virtual Team Team { get; set; }
    public virtual Player Player { get; set; }
}