
using Microsoft.Extensions.DependencyInjection;
using Publicaciones.Infraestructure.Interface;
using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Service;


namespace Publicaciones.IOC.Dependencies
{
    public static class AuthorDependency
    {
        public static void AddAuthorsDependency(this IServiceCollection services)
        {
            services.AddScoped<IAuthorsRepository, AuthorsRepository>();
            services.AddTransient<IAuthorsService, IAuthorsService>();
            

        }
    }
}
    

