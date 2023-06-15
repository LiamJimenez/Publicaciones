using Publicaciones.Domain.Core;
namespace Publicaciones.Domain.Entities
{
    public class Jobs : BaseEntity
    {
        public short job_id { get; set; }
        public string job_disc { get; set; }
        public byte min_lvl { get; set; }
    }
}
