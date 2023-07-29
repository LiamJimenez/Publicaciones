﻿using Microsoft.Extensions.Logging;
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
    public class titleAuthorRepository : BaseRepository<titleauthor>, ItitleAuthorRepository
    {
        private readonly PublicacionesContext context;
        private readonly ILogger<titleAuthorRepository> logger;

        public titleAuthorRepository(PublicacionesContext context,
                                      ILogger<titleAuthorRepository> logger) : base(context) 
        {
            this.context = context;
            this.logger = logger;
        }
        public override void Add(titleauthor entity)
        {
            if (this.Exists(cd => cd.title_id == entity.title_id)) 
            {
                throw new titleAuthorException("ttileauthor no existe");
            }

            base.Add(entity);
            base.SaveChanges();
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
            catch(Exception ex) 
            {
                this.logger.LogError("Error actualizando titleauthor", ex.ToString());
            }
            //base.Update(entity);
        }

        public override void Remove(titleauthor entity)
        {
            try 
            {
                titleauthor TitleAuthorToRemove = this.GetEntity(entity.au_id);

                TitleAuthorToRemove.au_id = entity.au_id;
                TitleAuthorToRemove.title_id = entity.title_id;
                TitleAuthorToRemove.au_ord = entity.au_ord;
                TitleAuthorToRemove.royaltyper = entity.royaltyper;

                this.context.titleauthor.Update(TitleAuthorToRemove);
                this.context.SaveChanges();
            }
            catch(Exception ex) 
            {
                this.logger.LogError("Error actualizando titleauthor", ex.ToString());
            }
            //base.Remove(entity);
        }
        public titleAuthorModel GetAuthorsByau_id(int id) 
        {
            titleAuthorModel TitleAuthorModel = new titleAuthorModel();

            try 
            {
                titleauthor Titleauthor = this.GetEntity(id);

                TitleAuthorModel.au_ord = Titleauthor.au_id;
                TitleAuthorModel.title_id = Titleauthor.title_id;
                TitleAuthorModel.au_ord = Titleauthor.au_ord;
                TitleAuthorModel.royaltyper = Titleauthor.royaltyper;
            }
            catch(Exception ex) 
            {
                this.logger.LogError("Error actualizando titleauthor", ex.ToString());
            }
            return TitleAuthorModel;
        }
        public List<titleAuthorModel> GetTitleAuthorModels() 
        {
            List<titleAuthorModel> titleAuthors = new List<titleAuthorModel>();
            try 
            {
                titleAuthors = this.context.titleauthor
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
                this.logger.LogError("Error actualizando titleauthor", ex.ToString());
            }
            return titleAuthors;
        }

        public titleAuthorModel GettitleAuthorByau_id(int au_id)
        {
            throw new NotImplementedException();
        }

        public List<titleAuthorModel> GetTitleAuthors()
        {
            throw new NotImplementedException();
        }
    }
}



//public class titleAuthorRepository : BaseRepository<titleauthor>, ItitleAuthorRepository
//{
//    private readonly ILogger<titleAuthorRepository> logger;
//    private readonly PublicacionesContext context;

//    public titleAuthorRepository(ILogger<titleAuthorRepository> logger,
//        PublicacionesContext context) : base(context)
//    {
//        this.logger = logger;
//        this.context = context;
//    }
//    public override void Add(titleauthor entity)
//    {

//        if (this.Exists(cd => cd.title_id == entity.title_id))
//            throw new titleAuthorException("El author ya existe.");

//        base.SaveChanges();
//        base.Add(entity);
//    }

//    public override void Update(titleauthor entity)
//    {
//        try
//        {
//            titleauthor TitleAuthorToUpdate = this.GetEntity(entity.au_id);

//            TitleAuthorToUpdate.au_id = entity.au_id;
//            TitleAuthorToUpdate.title_id = entity.title_id;
//            TitleAuthorToUpdate.au_ord = entity.au_ord;
//            TitleAuthorToUpdate.royaltyper = entity.royaltyper;

//            // here i dont put anything

//            this.context.titleauthor.Update(TitleAuthorToUpdate);
//            this.context.SaveChanges();
//        }
//        catch (Exception ex)
//        {

//            this.logger.LogError("Error actualizando al author", ex.ToString());
//        }
//    }
//    public override void Remove(titleauthor entity)
//    {
//        try
//        {
//            titleauthor titleAuthorToRemove = this.GetEntity(entity.au_id);

//            titleAuthorToRemove.Deleted = entity.Deleted;
//            titleAuthorToRemove.DeletedDate = entity.DeletedDate;
//            titleAuthorToRemove.UserDeleted = entity.UserDeleted;

//            this.context.titleauthor.Update(titleAuthorToRemove);
//            this.context.SaveChanges();

//        }
//        catch (Exception ex)
//        {

//            this.logger.LogError("Error eliminando el departamento", ex.ToString());
//        }
//    }



//    public titleAuthorModel GetAuthorsByau_id(string au_id)
//    {
//        titleAuthorModel TitleAuthorModel = new titleAuthorModel();


//        try
//        {
//            titleauthor TitleAuthor = this.GetEntity(au_id);

//            TitleAuthorModel.au_id = TitleAuthor.au_id;
//            TitleAuthorModel.title_id = TitleAuthor.title_id;
//            TitleAuthorModel.au_ord = TitleAuthor.au_ord;
//            TitleAuthorModel.royaltyper = TitleAuthor.royaltyper;

//        }
//        catch (Exception ex)
//        {

//            this.logger.LogError("Error obteniendo el author", ex.ToString());
//        }

//        return titleAuthorModel;
//    }
//    public List<titleAuthorModel> GettitleAuthor()
//    {

//        List<titleAuthorModel> authors = new List<titleAuthorModel>();

//        try
//        {
//            authors = this.context.titleauthor
//                             .Where(cd => !cd.Deleted)
//                             .Select(de => new titleAuthorModel()
//                             {
//                                 au_id = de.au_id,
//                                 title_id = de.title_id,
//                                 au_ord = de.au_ord,
//                                 royaltyper = de.royaltyper,


//                             }).ToList();
//        }
//        catch (Exception ex)
//        {

//            this.logger.LogError("Error obteniendo los departamentos", ex.ToString());
//        }

//        return authors;
//    }

//    public titleAuthorModel GettitleAuthorByau_id(string au_id)
//    {
//        throw new NotImplementedException();
//    }
//}