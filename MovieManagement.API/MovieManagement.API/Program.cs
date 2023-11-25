using MovieManagement.API;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureDatabase();

builder.ConfigureUnitOfWork();

var app = builder.Build();


app.MapGet("/", () => "Hello World!");

app.Run();
