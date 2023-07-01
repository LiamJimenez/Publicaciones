using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;

internal static class AuthorsAppExtentionHelpers
{

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
            result.Message = "El id del autor tiene la logitud invalida.";
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

            if (string.IsNullOrEmpty(model.city))
            {
                result.Message = "La ciudad del autor es requerido.";
                result.Success = false;
                return result;
            }

            if (model.city.Length > 50)
            {
                result.Message = "La ciudad del autor tiene la logitud invalida.";
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
                result.Message = "El codigo del autor tiene la logitud invalida.";
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
                result.Message = "El telefono del autor tiene la logitud invalida.";
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
                result.Message = "El estado del autor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            return result;
        }
    }
}