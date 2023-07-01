using Publicaciones.Domain.Core;

namespace Publicaciones.Domain.Entities
{
    public class Discount : BaseEntity
    {
        public string discountType { get; set; }
        public string? storId { get; set;}
        public short? lowqty { get; set;}
        public short? highqty { get; set;}
        public decimal discount { get; set;}        
    }

    

}
