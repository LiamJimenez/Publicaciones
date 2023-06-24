using Publicaciones.Domain.Entities;
using Publicaciones.Infraestructure.Models;

namespace Publicaciones.Infraestructure.Extentions
{
    public static class AuthorsExtention
    {
        public static AuthorsModel ConvertCourseEntityToModel(this Authors authors)
        {
            AuthorsModel authorsModel = new AuthorsModel()
            {
                au_id = authors.au_id,
                au_lname = authors.au_lname,
                au_fname = authors.au_fname,
                phone = authors.phone,
                address = authors.address,
                city = authors.city,
                state = authors.state,
                zip = authors.zip,
                contract = authors.contract
            };

            return authorsModel;
        }
    }
}

