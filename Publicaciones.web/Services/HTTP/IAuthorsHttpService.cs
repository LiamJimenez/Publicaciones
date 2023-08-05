using Publicaciones.web.Models.Responses;

namespace Publicaciones.web.Services.HTTP
{
    public interface IAuthorsHttpService : IHttpService<AuthorsListResponse,
                                                         AuthorsDetailResponse>
                                                        
                                                         
    {
    }
}