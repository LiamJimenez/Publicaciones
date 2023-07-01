using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Publicaciones.Infraestructure.Models
{
    public class DiscountModel
    {
        [Key]
        public string discountType { get; set; }
        public string? storId { get; set; }
        public short? lowqty { get; set; }
        public short? highqty { get; set; }
        public decimal discount { get; set; }
        public string creationuser { get; set; }
        public string creationdate { get; set; }
    }
}
