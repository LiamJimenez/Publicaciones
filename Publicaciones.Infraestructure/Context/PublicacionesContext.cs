using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Publicaciones.Domain.Entities;

namespace Publicaciones.Infraestructure.Context
{
    public class PublicacionesContext : DbContext
    {
        public PublicacionesContext()
        {
        }
        public PublicacionesContext(DbContextOptions<PublicacionesContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Empleoyess> Empleoyess { get; set;}
        public DbSet<Jobs> Jobs { get; set;}    
    }
}
