using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Domain.Entities;


namespace Publicaciones.Application.Extentions
{
    public static class AuthorsAppExtention
    {

            public static Authors ConvertDtoAddToEntity(this AuthorsAddDto authorsAddDto)
            {
                return new Authors()
                {

                    au_id = authorsAddDto.au_id,
                    au_fname = authorsAddDto.au_fname,
                    au_lname = authorsAddDto.au_lname,
                    city = authorsAddDto.city,
                    zip = authorsAddDto.zip,
                    phone = authorsAddDto.phone,
                    state = authorsAddDto.state,
                    modifydate = authorsAddDto.ChangeDate,
                    creationdate = authorsAddDto.ChangeDate,
                    creationuser = authorsAddDto.ChangeUser

                };
            }

            public static Authors ConvertDtoUpdateToEntity(this AuthorsUpdateDto authorsUpdateDto)
            {
                return new Authors()
                {
                    
                    au_id = authorsUpdateDto.au_id,
                    au_fname = authorsUpdateDto.au_fname,
                    au_lname = authorsUpdateDto.au_lname,
                    city = authorsUpdateDto.city,
                    zip = authorsUpdateDto.zip,
                    phone = authorsUpdateDto.phone,
                    state = authorsUpdateDto.state,
                    modifydate = authorsUpdateDto.ChangeDate,
                    creationdate = authorsUpdateDto.ChangeDate,
                    creationuser = authorsUpdateDto.ChangeUser

                };
            }

        public static ServiceResult IsValidAuthors(this AuthorsDto model)
        {
            ServiceResult result = new ServiceResult();

            if (string.IsNullOrEmpty(model.au_id))
            {
                result.Message = "El id del autor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.au_id.Length > 50)
            {
                result.Message = "El id del autor tiene una logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.au_fname))
            {
                result.Message = "El nombre del autor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.au_fname.Length > 50)
            {
                result.Message = "El nombre del autor tiene una logitud invalida.";
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
                result.Message = "El apellido del autor tiene una logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.city))
            {
                 result.Message = "La ciudad del autor es requerido.";
                 result.Success = false;
                 return result;
            }

            if (model.city.Length > 50)
            {
                  result.Message = "La ciudad del autor tiene una logitud invalida.";
                  result.Success = false;
                  return result;
            }

            if (string.IsNullOrEmpty(model.zip))
            {
                  result.Message = "El codigo del autor es requerido.";
                  result.Success = false;
                  return result;
            }

            if (model.zip.Length > 50)
            {
                  result.Message = "El codigo del autor tiene una logitud invalida.";
                  result.Success = false;
                  return result;
            }

            if (string.IsNullOrEmpty(model.phone))
            {
                 result.Message = "El telefono del autor es requerido.";
                 result.Success = false;
                 return result;
            }

            if (model.phone.Length > 50)
            {
                  result.Message = "El telefono del autor tiene una logitud invalida.";
                  result.Success = false;
                  return result;
            }

            if (string.IsNullOrEmpty(model.state))
            {
                  result.Message = "El estado del autor es requerido.";
                  result.Success = false;
                  return result;
            }

            if (model.state.Length > 50)
            {
                  result.Message = "El estado del autor tiene una logitud invalida.";
                  result.Success = false;
                  return result;
            }

               return result;
        }
    }
}

