
namespace Publicaciones.Application.Dtos.Authors
{
    public class AuthorsRemoveDto : DtoBase
    {
        public int au_id { get; set; }
        public bool Deleted { get; set; }
    }
}
