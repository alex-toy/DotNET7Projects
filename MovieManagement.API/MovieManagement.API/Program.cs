using MovieManagement.API;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureDatabase();

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
