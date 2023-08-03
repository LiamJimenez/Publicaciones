using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Publicaciones.Domain.Core;
using System.ComponentModel.DataAnnotations;

namespace Publicaciones.Domain.Entities
{
    public class titleauthor : BaseEntity
    {

        [Key]
        public string? au_id { get; set; }
        public string? title_id { get; set; }
        public byte au_ord { get; set; }
        public int royaltyper { get; set; }

    }
}
