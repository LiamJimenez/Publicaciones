using Publicaciones.Application.Contract;
using Publicaciones.Application.Service;
using Publicaciones.Infraestructure.Interface;
using Publicaciones.Infraestructure.Repositories;
using Publicaciones.web.Services;
using Publicaciones.web.Services.HTTP;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddHttpClient(); // Agregar el cliente HttpClient

builder.Services.AddTransient<IAuthorsHttpService, AuthorsHttpService>(); // Registrar la implementación AuthorsHttpService
builder.Services.AddTransient<IHttpRepository, HttpRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
