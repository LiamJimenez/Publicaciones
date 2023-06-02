namespace Publicaciones.Domain.Entities
{
    public class discount
    {
        public string DiscountType { get; set; }
        public char? StorId { get; set;}
        public short? Lowqty { get; set;}
        public short? Highqty { get; set;}
        public decimal Discount { get; set;}        
    }

    

}
