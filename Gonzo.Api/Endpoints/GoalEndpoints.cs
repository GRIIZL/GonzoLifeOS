using Gonzo.Api.Data;
using Gonzo.Api.Models;

public static class GoalEndpoints
{
    public static void MapGoalEndpoints(this WebApplication app)
    {
        app.MapGet("/goals", (GoalService service) =>
        {
            return service.GetGoals();
        });

        app.MapPost("/goals", (GoalService service, Goal goal) =>
        {
            var created = service.CreateGoal(goal);
            return Results.Ok(created);
        });
    }
}