using Microsoft.EntityFrameworkCore;
using Gonzo.Api.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<GoalService>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=GonzoLife.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGoalEndpoints();

app.UseHttpsRedirection();

app.Run();

