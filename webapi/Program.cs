using Microsoft.EntityFrameworkCore;
using webapi.Config;
using webapi.Dto;
using webapi.Models;
using webapi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite("localdb")
);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


builder.Services.AddAutoMapper(typeof(MappingConfig));

builder.Services.AddScoped<Irepository<User, UserData>>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
