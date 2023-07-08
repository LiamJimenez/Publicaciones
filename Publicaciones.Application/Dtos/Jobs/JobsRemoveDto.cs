
namespace Publicaciones.Application.Dtos.Jobs
{
    public class JobsRemoveDto : DtoBase
    {
        public string job_id { get; set; }
        public bool deleted { get; set; }
    }
}
