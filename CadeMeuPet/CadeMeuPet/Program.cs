using CadeMeuPet.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigureService(builder);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


void ConfigureService(WebApplicationBuilder builder)
{
    var connectionString = builder.Configuration.GetConnectionString("Conn");
    builder.Services.AddDbContext<DataContext>(opt => opt.UseSqlServer(connectionString));
}