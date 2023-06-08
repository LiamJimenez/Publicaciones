using Microsoft.Extensions.Logging;
using Publicaciones.Domain.Entities;
using Publicaciones.Infraestructure.Context;
using Publicaciones.Infraestructure.Core;
using Publicaciones.Infraestructure.Exceptions;
using Publicaciones.Infraestructure.Interface;
using Publicaciones.Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Publicaciones.Infraestructure.Repositories
{
    internal class AuthorsRepository : BaseRepository<Authors>, IAuthorsRepository
    {
        private readonly ILogger<AuthorsRepository> logger;
        private readonly PublicacionesContext context;

        public AuthorsRepository(ILogger<AuthorsRepository> logger,
            PublicacionesContext context): base(context) 
        {
            this.logger = logger;
            this.context = context;
        }

        public List<AuthorsModel> GetAuthorsByzip(int zip)
        {
            List<AuthorsModel> authors = new List<AuthorsModel>();

            try
            {
                this.logger.LogInformation($"Pase por aqui: {zip}");

                authors = (from au in base.GetEntities()
                          join de in context.Authors.ToList() on au.zip equals de.zip
                          where au.zip == zip
                          select new AuthorsModel()
                          {
                              au_Iname = au.au_Iname,
                              au_fname = au.au_fname,
                              address = au.address,
                              city = au.city,
                              state = au.state,
                              zip = au.zip,



                          }).ToList();

            }
            catch (Exception ex)
            {
                this.logger.LogError($"Error obeteniendo a los autores: {ex.Message}", ex.ToString());
            }

            return authors;
        }

        public override void Add(Authors entity)
        {

            if (this.Exists(cd => cd.au_fname == entity.au_fname))
                throw new AuthorsException("El author ya existe.");

            base.SaveChanges();
        }
    }
}
