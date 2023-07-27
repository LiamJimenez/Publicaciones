namespace Publicaciones.web.Models.Responses
{
    public class AuthorsListResponse : BaseResponse
    {
        public List<AuthorModel> data { get; set; }
    }
}
