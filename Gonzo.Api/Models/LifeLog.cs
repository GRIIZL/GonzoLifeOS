namespace Gonzo.Api.Models;

public class LifeLog
{
    public int Id { get; set; }
    public string ActivityName { get; set; } = string.Empty;
    public int ImpactScore { get; set; }
    public string Note { get; set; } = string.Empty;
    public DateTime Timesatamp { get; set; } = DateTime.UtcNow;
}