using Publicaciones.web.Models.Responses;

namespace Publicaciones.web.Services.HTTP
{
    public interface IHttpService<List, Details>
    {
        public List Get();
        public Details GetByau_id(string au_id);
     
        
    }
}