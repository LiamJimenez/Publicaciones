using System;
using System.Collections.Generic;
using System.Text;

namespace Publicaciones.Application.Dtos.titleauthor
{
    public abstract class titleAuthorDto : DtoBase
    {
        public int au_id { get; set; }
        public string? title_id { get; set; }
        public int au_ord { get; set; }
        public int royaltyper { get; set; }

    }
}
