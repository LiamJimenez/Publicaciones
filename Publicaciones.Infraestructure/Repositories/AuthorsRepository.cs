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
    public class AuthorsRepository : BaseRepository<Authors>, IAuthorsRepository
    {
        private readonly ILogger<AuthorsRepository> logger;
        private readonly PublicacionesContext context;

        public AuthorsRepository(ILogger<AuthorsRepository> logger,
            PublicacionesContext context) : base(context)
        {
            this.logger = logger;
            this.context = context;
        }
        public override void Add(Authors entity)
        {

            if (this.Exists(cd => cd.au_fname == entity.au_fname))
                throw new AuthorsException("El author ya existe.");

            base.SaveChanges();
            base.Add(entity);
        }

        public override void Update(Authors entity)
        {
            try
            {
                Authors authorsToUpdate = this.GetEntity(entity.au_id);

                authorsToUpdate.au_id = entity.au_id;
                authorsToUpdate.modifydate = entity.modifydate;
                authorsToUpdate.au_lname = entity.au_lname;
                authorsToUpdate.au_fname = entity.au_fname;
                authorsToUpdate.usermod = entity.usermod;
                authorsToUpdate.phone = entity.phone;
                authorsToUpdate.address = entity.address;
                authorsToUpdate.city = entity.city;
                authorsToUpdate.state = entity.state;
                authorsToUpdate.zip = entity.zip;
                authorsToUpdate.contract = entity.contract;

                this.context.Authors.Update(authorsToUpdate);
                this.context.SaveChanges();
            }
             catch (Exception ex)
            {

                this.logger.LogError("Error actualizando al author", ex.ToString());
            }
        }
        public override void Remove(Authors entity)
        {
            try
            {
                Authors authorsToRemove = this.GetEntity(entity.au_id);

                authorsToRemove.deleted = entity.deleted;
                authorsToRemove.deleteddate = entity.deleteddate;
                authorsToRemove.userdeleted = entity.userdeleted;

                this.context.Authors.Update(authorsToRemove);
                this.context.SaveChanges();

            }
            catch (Exception ex)
            {

                this.logger.LogError("Error eliminando el departamento", ex.ToString());
            }
        }



        public AuthorsModel GetAuthorsByau_id(string au_id)
        {
            AuthorsModel authorsModel = new AuthorsModel();


            try
            {
                Authors authors = this.GetEntity(au_id);

                authorsModel.city = authors.city;
                authorsModel.au_id = authors.au_id;
                authorsModel.address = authors.address;
                authorsModel.au_fname = authors.au_fname;
                authorsModel.au_lname = authors.au_lname;

            }
            catch (Exception ex)
            {

                this.logger.LogError("Error obteniendo el author", ex.ToString());
            }

            return authorsModel;
        }
        public List<AuthorsModel> GetAuthors()
        {

            List<AuthorsModel> authors = new List<AuthorsModel>();

            try
            {
                authors = this.context.Authors
                                 .Where(cd => !cd.deleted)
                                 .Select(de => new AuthorsModel()
                                 {
                                     city = de.city,
                                     au_id = de.au_id,
                                     au_fname = de.au_fname,
                                     au_lname = de.au_lname,
                                     address = de.address,
                                 
                                 }).ToList();
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error obteniendo los departamentos", ex.ToString());
            }

            return authors;
        }

    }
}




