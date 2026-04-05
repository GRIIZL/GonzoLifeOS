namespace Gonzo.Api.Models;

public class Goal
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = "General";
    public int Difficulty { get; set; }
    public decimal Cost { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CratedAt { get; set; } = DateTime.UtcNow;

}