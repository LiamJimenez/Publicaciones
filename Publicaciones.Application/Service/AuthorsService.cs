using Microsoft.Extensions.Logging;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Application.Extentions;
using Publicaciones.Domain.Entities;
using Publicaciones.Domain.Repository;
using Publicaciones.Infraestructure.Exceptions;
using Publicaciones.Infraestructure.Interface;
using System;

namespace Publicaciones.Application.Service
{
    public class AuthorsService : IAuthorsService
    {
        private readonly IAuthorsRepository authorsRepository;
        private readonly ILogger<AuthorsService> logger;

        public AuthorsService(IAuthorsRepository authorsRepository,
                                  ILogger<AuthorsService> logger)
        {
            this.authorsRepository = authorsRepository;
            this.logger = logger;
        }

        public ServiceResult Get()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.authorsRepository.GetAuthors();
            }
            catch (AuthorsException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los deparmentos";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetByau_id(string au_id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.authorsRepository.GetAuthorsByau_id(au_id);
            }
            catch (AuthorsException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los Autores";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult Remove(AuthorsRemoveDto model)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                this.authorsRepository.Remove(new Authors()
                {
                    au_id = model.au_id,
                    deleted = model.deleted,
                    deleteddate = model.ChangeDate,
                    userdeleted = model.ChangeUser
                });

                result.Message = "Author eliminado correctamente.";

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el departamento.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Save(AuthorsAddDto model)
        {
            ServiceResult result = new ServiceResult();

            if (string.IsNullOrEmpty(model.au_fname))
            {
                result.Message = "El nombre del autor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.au_fname.Length > 50)
            {
                result.Message = "El nombre del autor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.au_lname))
            {
                result.Message = "El apellido del autor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.au_lname.Length > 50)
            {
                result.Message = "El apellido del autor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }


            try
            {
                var authors = model.ConvertDtoAddToEntity();

                this.authorsRepository.Add(authors);

                result.Message = "Autor agregado correctamente.";
            }
            catch (AuthorsException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el Autor.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Update(AuthorsUpdateDto model)
        {
            ServiceResult result = new ServiceResult();

            if (string.IsNullOrEmpty(model.au_lname))
            {
                result.Message = "El nombre del autor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.au_lname.Length > 50)
            {
                result.Message = "El nombre del autor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            try
            {
                var authors = model.ConvertDtoUpdateToEntity();

                this.authorsRepository.Update(authors);

                result.Message = "autor actualizado correctamente.";
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el autor.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }



            return result;
        }
    }
}

