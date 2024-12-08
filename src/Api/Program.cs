using Api.Abstractions;
using Api.implamentations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ITestService, TestService>();

var app = builder.Build();
string[] answersUser = { "false", "false", "false", "false", "false" };

string path = "note1.txt";

string text = string.Join(",",answersUser);



app.MapGet("/task/{id}", (int id,
    [FromServices] ITestService testService) => 
{
    return Results.Ok(testService.PrintTest(id));
});

app.MapPost("/task/{taskid}/{anwser}", (int taskid, string anwser,
    [FromServices] ITestService testService) =>
{
    return Results.Ok(testService.WriteAnwser(taskid, anwser, answersUser));
});

app.MapGet("/task/result", (
    [FromServices] ITestService testService) =>
{
    return Results.Ok(testService.PrintAwners(answersUser));
});

app.MapGet("/task/reset", (
    [FromServices] ITestService testService) =>
{
    return Results.Ok(testService.ResetAwners(answersUser));
});

app.Run();