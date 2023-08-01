
namespace Publicaciones.Application.Dtos.Authors
{
    public class AuthorsRemoveDto : DtoBase
    {
        public string? au_id { get; set; }
        public bool deleted { get; set; }
    }
}
