using tmp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<MyMiddleware>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseMiddleware<MyMiddleware>();

app.Run();
