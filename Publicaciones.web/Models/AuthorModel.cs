using System.ComponentModel.DataAnnotations;

namespace Publicaciones.web.Models
{
    public class AuthorModel
    {

        public string? au_id { get; set; }
        public string? au_lname { get; set; }
        public string? au_fname { get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zip { get; set; }
        public bool? contract { get; set; }
    }
}
