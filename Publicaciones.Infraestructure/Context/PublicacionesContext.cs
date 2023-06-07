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
        public DbSet<Sales> Sales { get; set; }
        public DbSet<discount> discount { get; set; }
        public DbSet<titleauthor> titleauthor { get; set; }
        public DbSet<Empleoyess> Empleoyess { get; set; }
        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<publicInfo> pub_info { get; set; }
        public DbSet<Publishes> Publishes { get; set; }


    }
}
