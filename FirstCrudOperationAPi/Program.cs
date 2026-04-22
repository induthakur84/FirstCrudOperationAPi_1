using FirstCrudOperationAPi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("abc")));


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

//why we use program.cs file in asp.net core?
// program .cs file in ASP.NET Core is the entry point of the application. It contains the Main method, which is the starting point of the application execution. In this file, you can configure services, middleware, and other components that are necessary for the application to run. It also sets up the web host and starts the application. The program.cs file is essential for bootstrapping the application and defining its behavior during startup.
