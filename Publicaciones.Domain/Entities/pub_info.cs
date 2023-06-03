using Publicaciones.Domain.Core;
using System.Reflection;

namespace Publicaciones.Domain.Entities
{
    public class pub_info : BaseEntity
    {
        public char pub_id {  get; set; }
        public byte[]? Logo { get; set; }
        public string? pr_info { get; set; }
    }
}
