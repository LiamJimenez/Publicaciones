using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Domain.Entities;


namespace Publicaciones.Application.Extentions
{
    public static class JobsAppExtention
    {

        public static Jobs ConvertDtoAddToEntity(this JobsAddDto jobsAddDto)
        {
            return new Jobs()
            {

                job_id = jobsAddDto.job_id,
                job_disc = jobsAddDto.job_disc,
                min_lvl = jobsAddDto.min_lvl,
                modifydate = authorsAddDto.ChangeDate,
                creationdate = authorsAddDto.ChangeDate,
                creationuser = authorsAddDto.ChangeUser
            };
        }

        public static Jobs ConvertDtoUpdateToEntity(this JobsUpdateDto jobsUpdateDto)
        {
            return new Jobs()
            {

                job_id = jobsAddDto.job_id,
                job_disc = jobsAddDto.job_disc,
                min_lvl = jobsAddDto.min_lvl,
                modifydate = authorsAddDto.ChangeDate,
                creationdate = authorsAddDto.ChangeDate,
                creationuser = authorsAddDto.ChangeUser

            };
        }

        public static ServiceResult IsValidAuthors(this JobsDto model)
        {
            ServiceResult result = new ServiceResult();

            if (string.IsNullOrEmpty(model.job_id))
            {
                result.Message = "El id del trabajo es requerido.";
                result.Success = false;
                return result;
            }

            if (model.job_id.Length > 50)
            {
                result.Message = "El id del trabajo tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.job_disc))
            {
                result.Message = "El job disc del trabajo es requerido.";
                result.Success = false;
                return result;
            }

            if (model.job_disc.Length > 50)
            {
                result.Message = "El job disc del trabajo tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.min_lvl))
            {
                result.Message = "El min_lvl del trabajo es requerido.";
                result.Success = false;
                return result;
            }

            if (model.min_lvl.Length > 50)
            {
                result.Message = "El min_lvl del trabajo tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            return result;
        }
    }
}

