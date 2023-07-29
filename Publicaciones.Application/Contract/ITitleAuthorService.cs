using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.titleauthor;

namespace Publicaciones.Application.Contract
{
    public interface ITitleAuthorService : IBaseService<TitleAuthorAddDto, titleAuthorUpdateDto, titleAuthorRemoveDto>
    {
        //ServiceResult Save(TitleAuthorAddDto model);
        //object GetById(int id);
    }
}
