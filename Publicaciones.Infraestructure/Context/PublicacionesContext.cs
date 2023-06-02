using Microsoft.EntityFrameworkCore;
using Publicaciones.Domain.Entities;

namespace Publicaciones.Infraestructure.Context
{
    public class PublicacionesContext : DbContext
    {
        protected PublicacionesContext()
        {

        }
        public PublicacionesContext(DbContextOptions <PublicacionesContext> options) : base(options)
        {

        }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<discount> Discounts { get; set; }
    }
}
