using Gonzo.Api.Data;
using Gonzo.Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class GoalService
{
    private readonly AppDbContext _context;
    public GoalService(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }
    public Goal CreateGoal(Goal goal)
    {
        _context.Goals.Add(goal);
        _context.SaveChanges();

        return goal;
    }

    public List<Goal> GetGoals()
    {
        return _context.Goals.ToList();
    }
}