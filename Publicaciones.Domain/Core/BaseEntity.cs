using System;

namespace Publicaciones.Domain.Core
{
    
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            this.creationdate = DateTime.Now;
            this.deleted = false;
        }
        public int creationuser { get; set; }
        public DateTime creationdate { get; set; }
        public int? usermod { get; set; }
        public DateTime? modifydate { get; set; }
        public int? userdeleted { get; set; }
        public DateTime? deleteddate { get; set; }
        public bool deleted { get; set; }
    }
}
