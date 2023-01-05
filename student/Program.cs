using student.Models;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddDbContext<StudentContext>(options =>
//options.UseSql
builder.Services.AddDbContext<StudentContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")) );


//options.UseNpgsql(builder.Configuration.GetConnectionString("Host=localhost;Database=postgres;Username=postgres;Password=postgres")));

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
