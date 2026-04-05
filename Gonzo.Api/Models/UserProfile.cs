namespace Gonzo.Api.Models;

public class UserProfile
{
    public int Id { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public decimal MonthlyIncome { get; set; }
    public int FreeHoursPerDay { get; set; }
}