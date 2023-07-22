using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Domain.Entities;
using System.Collections.Generic;
using Publicaciones.Infraestructure.Models;


namespace Publicaciones.Infraestructure.Interface
{
    public interface IAuthorsRepository : IBaseRepository<Authors>
    {
        List<AuthorsModel> GetAuthors();
        AuthorsModel GetAuthorsByau_id(string au_id);
    }
            
}
    

