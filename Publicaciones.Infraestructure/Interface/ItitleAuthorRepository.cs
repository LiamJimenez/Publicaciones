using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Domain.Entities;

using System.Collections.Generic;
using Publicaciones.Infraestructure.Models;
using System;

namespace Publicaciones.Infraestructure.Interface
{
    public interface ItitleAuthorRepository : IBaseRepository<titleauthor> 
    {
        titleAuthorModel GettitleAuthorByau_id(int au_id);
        List<titleAuthorModel> GetTitleAuthors();
        
    }
}

//public interface ItitleAuthorRepository : IBaseRepository<titleauthor>
//{
//    List<titleAuthorModel> GettitleAuthor();
//    titleAuthorModel GettitleAuthorByau_id(string au_id);
//}

