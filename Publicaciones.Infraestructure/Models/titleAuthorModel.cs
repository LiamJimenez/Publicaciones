using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Publicaciones.Infraestructure.Models
{
    public class titleAuthorModel
    {

        [Key]
        public int au_id { get; set; }
        public string? title_id { get; set; }
        public int au_ord { get; set; }
        public int royaltyper { get; set; }


    }
}