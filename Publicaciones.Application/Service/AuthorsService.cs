using Microsoft.Extensions.Logging;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;
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
            throw new NotImplementedException();
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
                this.authorsRepository.Add(new Authors()
                {
                    city = model.city,
                    au_id = model.au_id,
                    au_fname = model.au_fname,
                    au_lname = model.au_lname,
                    zip = model.zip,
                    contract = model.contract,
                    phone = model.phone,
                    state = model.state,
                    modifydate = model.ChangeDate,
                    creationdate = model.ChangeDate,
                    creationuser = model.ChangeUser
                });

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



            this.authorsRepository.Update(new Authors()
            {
                
            });


            return result;
        }
    }
}
