using MovieManagement.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.ConfigureDatabase();

builder.ConfigureUnitOfWork();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
