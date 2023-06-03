using Publicaciones.Domain.Core;

namespace Publicaciones.Domain.Entities
{
    public class Jobs : BaseEntity
    {
        public int job_id {  get; set; }
        public string job_desc { get; set; }
        public byte min_IvI { get; set; }
        public byte max_IvI { get; set; }
    }
}
