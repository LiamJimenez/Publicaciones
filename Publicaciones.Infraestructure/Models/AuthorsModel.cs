using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Publicaciones.Infraestructure.Models
{
    public class AuthorsModel
    {

        [Key]
        public char? au_id { get; set; }
        public string? au_lname { get; set; }
        public string? au_fname { get; set; }
        public char? phone { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public char state { get; set; }
        public char zip { get; set; }
        public bool? contract { get; set; }

    }
}
