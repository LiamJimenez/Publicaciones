using System;
using System.Collections.Generic;
using System.Text;

namespace Publicaciones.Application.Dtos.titleauthor
{
    internal class titleAuthorDto : DtoBase
    {
        public string au_id { get; set; }
        public string title_id { get; set; }
        public int? au_ord { get; set; }
        public int? royaltyper { get; set; }

    }
}
