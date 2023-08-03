using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.titleauthor;
using Publicaciones.Domain.Entities;


namespace Publicaciones.Application.Extentions
{
    public static class TitleAuthorExtentions
    {
        public static titleauthor ConvertDtoAddToEntity(this TitleAuthorAddDto TITLEauthorsAddDto)
        {
            return new titleauthor()
            {

                au_id = TITLEauthorsAddDto.au_id,
                title_id = TITLEauthorsAddDto.title_id,
                au_ord = TITLEauthorsAddDto.au_ord,
                royaltyper = TITLEauthorsAddDto.royaltyper

            };
        }

        public static titleauthor ConvertDtoUpdateToEntity(this titleAuthorUpdateDto TITLEauthorUpdateDto)
        {
            return new titleauthor()
            {

                au_id = TITLEauthorUpdateDto.au_id,
                title_id = TITLEauthorUpdateDto.title_id,
                au_ord = TITLEauthorUpdateDto.au_ord,
                royaltyper = TITLEauthorUpdateDto.royaltyper


            };
        }

        public static ServiceResult IsValidAuthors(this titleAuthorDto model)
        {
            ServiceResult result = new ServiceResult();

            //if (model.au_id == 0)
            //{
            //    result.Message = "El id del titleAuthor es requerido.";
            //    result.Success = false;
            //    return result;
            //}

            if (string.IsNullOrEmpty(model.au_id))
            {
                result.Message = "El id del titleAuthor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.title_id))
            {
                result.Message = "El nombre del titleAuthor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.title_id.Length > 50)
            {
                result.Message = "El nombre del titleAuthor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (model.au_ord == 0)
            {
                result.Message = "El apellido del titleAuthor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.au_ord > 50)
            {
                result.Message = "El apellido del autor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (model.royaltyper == 0)
            {
                result.Message = "El apellido del titleAuthor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.royaltyper > 50)
            {
                result.Message = "La ciudad del titleautor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            return result;
        }
    }
}