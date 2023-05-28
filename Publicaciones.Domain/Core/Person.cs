namespace Publicaciones.Domain.Core
{
    public abstract class Person : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public char phone { get; set; }
        public string Email { get; set; }
        public string Cedula { get; set; }



    }
}
