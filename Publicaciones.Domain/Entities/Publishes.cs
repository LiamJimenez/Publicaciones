using Publicaciones.Domain.Core;
using System.Reflection;

namespace Publicaciones.Domain.Entities
{
    public class Publishes : BaseEntity
    { 
        public char pub_info { get; set; }
        public string? pub_name { get; set; }
        public string? city { get; set; }
        public char? state { get; set; }
        public string? country { get; set; }

        
        }
}
