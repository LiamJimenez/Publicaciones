using System;
using System.Collections.Generic;
using System.Text;

namespace Publicaciones.Application.Dtos.titleauthor
{
    public class titleAuthorRemoveDto : DtoBase
    {
        public string? au_id { get; set; }
        public bool Deleted { get; set; }

    }
}
