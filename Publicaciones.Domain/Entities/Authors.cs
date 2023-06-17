using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using Publicaciones.Domain.Core;

namespace Publicaciones.Domain.Entities
{
    public class Authors : BaseEntity
    {

        [Key]
        public char au_id { get; set; }
        public string? au_lname { get; set; }
        public string? au_fname { get; set;}
        public char? phone { get; set;}
        public string? address { get; set;}
        public string? city { get; set;}
        public char state { get; set;}
        public char zip { get; set;}
        public bool? contract { get; set;}

    }
}
