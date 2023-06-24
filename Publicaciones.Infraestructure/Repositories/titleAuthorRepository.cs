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
    public class AuthorsRepository : BaseRepository<titleauthor>, ItitleAuthorRepository
    {
        private readonly ILogger<AuthorsRepository> logger;
        private readonly PublicacionesContext context;

        public AuthorsRepository(ILogger<AuthorsRepository> logger,
            PublicacionesContext context) : base(context)
        {
            this.logger = logger;
            this.context = context;
        }
        public override void Add(titleauthor entity)
        {

            if (this.Exists(cd => cd.title_id == entity.title_id))
                throw new titleAuthorException("El author ya existe.");

            base.SaveChanges();
            base.Add(entity);
        }

        public override void Update(titleauthor entity)
        {
            try
            {
                titleauthor TitleAuthorToUpdate = this.GetEntity(entity.au_id);

                TitleAuthorToUpdate.au_id = entity.au_id;
                TitleAuthorToUpdate.title_id = entity.title_id;
                TitleAuthorToUpdate.au_ord = entity.au_ord;
                TitleAuthorToUpdate.royaltyper = entity.royaltyper;
                
               // here i dont put anything

                this.context.titleauthor.Update(authorsToUpdate);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error actualizando al author", ex.ToString());
            }
        }
        public override void Remove(titleauthor entity)
        {
            try
            {
                titleauthor authorsToRemove = this.GetEntity(entity.au_id);

                authorsToRemove.deleted = entity.deleted;
                authorsToRemove.deleteddate = entity.deleteddate;
                authorsToRemove.userdeleted = entity.userdeleted;

                this.context.titleauthor.Update(authorsToRemove);
                this.context.SaveChanges();

            }
            catch (Exception ex)
            {

                this.logger.LogError("Error eliminando el departamento", ex.ToString());
            }
        }



        public titleAuthorModel GetAuthorsByau_id(string au_id)
        {
            titleAuthorModel TitleAuthorModel = new titleAuthorModel();


            try
            {
                titleauthor authors = this.GetEntity(au_id);

                TitleAuthorModel.city = authors.city;
                TitleAuthorModel.au_id = authors.au_id;
                TitleAuthorModel.address = authors.address;
                TitleAuthorModel.au_fname = authors.au_fname;
                TitleAuthorModel.au_lname = authors.au_lname;

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



