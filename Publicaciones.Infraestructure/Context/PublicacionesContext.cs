using Microsoft.EntityFrameworkCore;
using Publicaciones.Domain.Entities;

namespace Publicaciones.Infraestructure.Context
{
    public class PublicacionesContext : DbContext
    {

        public PublicacionesContext()
        { 
        }
        public PublicacionesContext(DbContextOptions<PublicacionesContext> options) 
            : base(options) { 
        }

        public DbSet<Authors> Authors { get; set; }
       


    }
}
