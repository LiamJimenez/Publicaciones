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

                this.context.titleauthor.Update(TitleAuthorToUpdate);
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
                titleauthor titleAuthorToRemove = this.GetEntity(entity.au_id);

                titleAuthorToRemove.Deleted = entity.Deleted;
                titleAuthorToRemove.DeletedDate = entity.DeletedDate;
                titleAuthorToRemove.UserDeleted = entity.UserDeleted;

                this.context.titleauthor.Update(titleAuthorToRemove);
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
                titleauthor TitleAuthor = this.GetEntity(au_id);

                TitleAuthorModel.au_id = TitleAuthor.au_id;
                TitleAuthorModel.title_id = TitleAuthor.title_id;
                TitleAuthorModel.au_ord = TitleAuthor.au_ord;
                TitleAuthorModel.royaltyper = TitleAuthor.royaltyper;

            }
            catch (Exception ex)
            {

                this.logger.LogError("Error obteniendo el author", ex.ToString());
            }

            return titleAuthorModel;
        }
        public List<titleAuthorModel> GettitleAuthor()
        {

            List<titleAuthorModel> authors = new List<titleAuthorModel>();

            try
            {
                authors = this.context.titleauthor
                                 .Where(cd => !cd.Deleted)
                                 .Select(de => new titleAuthorModel()
                                 {
                                     au_id = de.au_id,
                                     title_id = de.title_id,
                                     au_ord = de.au_ord,
                                     royaltyper = de.royaltyper,
                                     

                                 }).ToList();
            }
            catch (Exception ex)
            {

                this.logger.LogError("Error obteniendo los departamentos", ex.ToString());
            }

            return authors;
        }

        public titleAuthorModel GettitleAuthorByau_id(string au_id)
        {
            throw new NotImplementedException();
        }
    }
}



