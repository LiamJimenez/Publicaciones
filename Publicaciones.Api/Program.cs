
using Microsoft.EntityFrameworkCore;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Service;
using Publicaciones.Infraestructure.Context;
using Publicaciones.Infraestructure.Interface;
using Publicaciones.Infraestructure.Repositories;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Registro de dependencia base de de datos //
builder.Services.AddDbContext<PublicacionesContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PublicacionesContext")));

// Repositories //
builder.Services.AddTransient<IEmployeesRepository, EmployeesRepository>();
builder.Services.AddTransient<IJobsRepository, JobsRepository>();

// Registros de app services //
builder.Services.AddTransient<IEmployeesService, EmployeesService>();
builder.Services.AddTransient<IJobsService, JobsService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();


