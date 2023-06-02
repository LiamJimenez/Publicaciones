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

        public DbSet<Authors> Autor { get; set; }
        public DbSet<Sales> Sale { get; set; }
        public DbSet<titleauthor> titleauthor { get; set; }
        

    }
}
