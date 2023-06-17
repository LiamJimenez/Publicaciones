using System;
using System.Collections.Generic;
using System.Text;

namespace Publicaciones.Application.Dtos.Authors
{
    public abstract class AuthorsDto : DtoBase
    {
        public string? au_lname { get; set; }
        public string? au_fname { get; set; }
        public char? phone { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public char state { get; set; }
        public char zip { get; set; }
        public bool? contract { get; set; }
    }
}
