using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.UserLayer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserService>();

builder.Services.AddDbContext<ApplicationDbContext>(options => 
    {
        options.UseSqlite("Users");
    });

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
