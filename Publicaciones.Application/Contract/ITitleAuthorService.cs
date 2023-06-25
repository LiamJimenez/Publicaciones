using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.titleauthor;

namespace Publicaciones.Application.Contract
{
    public interface ITitleAuthorService : IBaseService<titleAuthorAddDto, titleAuthorUpdateDto, titleAuthorRemoveDto>
    {

    }
}
