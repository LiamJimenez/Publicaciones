using System.ComponentModel.DataAnnotations;

using Publicaciones.Domain.Core;

namespace Publicaciones.Domain.Entities
{
    public class Authors : BaseEntity
    {

        [Key]
        public string au_id { get; set; }
        public string? au_lname { get; set; }
        public string? au_fname { get; set;}
        public string? phone { get; set;}
        public string address { get; set;}
        public string? city { get; set;}
        public string state { get; set;}
        public string zip { get; set;}
        public bool? contract { get; set;}

    }
}
