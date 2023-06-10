using System;
using System.ComponentModel.DataAnnotations;
using Publicaciones.Domain.Core;

namespace Publicaciones.Domain.Entities
{
    public class Authors 
    {

        [Key]
        public char? au_id { get; set; }
        public string? au_lname { get; set; }
        public string? au_fname { get; set;}

        public string address { get; set;}
        public string city { get; set;}
        public char state { get; set;}
        public char zip { get; set;}
        public byte contract { get; set;}

    }
}
