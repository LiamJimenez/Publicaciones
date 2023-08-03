using Microsoft.Extensions.Logging;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.titleauthor;
using Publicaciones.Application.Extentions;
using Publicaciones.Domain.Entities;
using Publicaciones.Domain.Repository;
using Publicaciones.Infraestructure.Core;
using Publicaciones.Infraestructure.Exceptions;
using Publicaciones.Infraestructure.Interface;
using Publicaciones.Infraestructure.Repositories;
using System;

namespace Publicaciones.Application.Service
{
    public class titleAuthorService : ITitleAuthorService
    {
        private readonly ItitleAuthorRepository TitleAuthorRepository;
        private readonly ILogger<titleAuthorService> logger;

        public titleAuthorService(ItitleAuthorRepository TitleAuthorRepository,
                                  ILogger<titleAuthorService> logger)
        {
            this.TitleAuthorRepository = TitleAuthorRepository;
            this.logger = logger;
        }

        public ServiceResult Get()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.TitleAuthorRepository.GetTitleAuthors();
            }
            catch (titleAuthorException dex)
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
                result.Data = this.TitleAuthorRepository.GettitleAuthorByau_id(au_id);
            }
            catch (titleAuthorException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los titleAuthor";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }
            public ServiceResult Remove(titleAuthorRemoveDto model)
            {
                ServiceResult result = new ServiceResult();

                try
                {
                    this.TitleAuthorRepository.Remove(new titleauthor()
                    {
                        au_id = model.au_id,
                        Deleted = model.Deleted,
                        DeletedDate = model.ChangeDate,
                        UserDeleted = model.ChangeUser
                    });

                    result.Message = "TitleAuthor eliminado correctamente.";

                }
                catch (Exception ex)
                {

                    result.Success = false;
                    result.Message = "Error guardando el departamento.";
                    this.logger.LogError($"{result.Message}", ex.ToString());
                }

                return result;
            }

            public ServiceResult Save(TitleAuthorAddDto model)
            {
                ServiceResult result = new ServiceResult();

                if (string.IsNullOrEmpty(model.title_id))
                {
                    result.Message = "El nombre del titleUthor es requerido.";
                    result.Success = false;
                    return result;
                }

                if (model.title_id.Length > 50)
                {
                    result.Message = "El nombre del autor tiene la logitud invalida.";
                    result.Success = false;
                    return result;
                }

                if (string.IsNullOrEmpty(model.title_id))
                {
                    result.Message = "El apellido del autor es requerido.";
                    result.Success = false;
                    return result;
                }

                if (model.title_id.Length > 50)
                {
                    result.Message = "El apellido del autor tiene la logitud invalida.";
                    result.Success = false;
                    return result;
                }


                try
                {
                  var TitleAuthors = model.ConvertDtoAddToEntity();

                  this.TitleAuthorRepository.Add(TitleAuthors);

                  result.Message = "titeauthors agregado correctamente.";
            }
                catch (titleAuthorException dex)
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

        //public ServiceResult Save(TitleAuthorAddDto model)
        //{
        //    throw new NotImplementedException();
        //}

        public ServiceResult Update(titleAuthorUpdateDto model)
            {
                ServiceResult result = new ServiceResult();

                if (string.IsNullOrEmpty(model.title_id))
                {
                    result.Message = "El nombre del titleautor es requerido.";
                    result.Success = false;
                    return result;
                }

                if (model.title_id.Length > 50)
                {
                    result.Message = "El nombre del TitleAuthor tiene la logitud invalida.";
                    result.Success = false;
                    return result;
                }

                try
                {
                    var TITLEAuthors = model.ConvertDtoUpdateToEntity();

                    this.TitleAuthorRepository.Update(TITLEAuthors);

                    result.Message = "TitleAuthor actualizado correctamente.";
                }
                catch (Exception ex)
                {

                    result.Success = false;
                    result.Message = "Error guardando el TitleAuthor.";
                    this.logger.LogError($"{result.Message}", ex.ToString());
                }



                return result;
            }

        //ServiceResult IBaseService<TitleAuthorAddDto, titleAuthorUpdateDto, titleAuthorRemoveDto>.Save(TitleAuthorAddDto model)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
