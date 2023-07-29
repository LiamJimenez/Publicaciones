
using Microsoft.Extensions.DependencyInjection;
using Publicaciones.Infraestructure.Interface;
using Publicaciones.Infraestructure.Repositories;

namespace Publicaciones.IOC.Dependencies
{
    public static class TitleAuthorDependency
    {
        public static void AddTitleAuthorDependency(this IServiceCollection services) 
        {
            services.AddScoped<ItitleAuthorRepository, titleAuthorRepository>();
            services.AddTransient<ItitleAuthorRepository, titleAuthorRepository>();

        }
    }
}
