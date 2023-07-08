

namespace Publicaciones.Application.Dtos.Jobs
{
    public abstract class JobsDto : DtoBase
    {
        public short job_id { get; set; }
        public string job_disc { get; set; }
        public byte min_lvl { get; set; }
    }
}