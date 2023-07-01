using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Publicaciones.Infraestructure.Models
{
    public class SalesModel
    {
        [Key]
        public string stor_id { get; set; }
        public string ord_num { get; set; }
        public DateTime ord_date { get; set; }
        public short qty { get; set; }
        public string payterms { get; set; }
        public string title_id { get; set; }
        public string creationuser { get; set; }
        public string creationdate { get; set; }
    }
}
