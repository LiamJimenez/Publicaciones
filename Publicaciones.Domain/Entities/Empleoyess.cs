using Publicaciones.Domain.Core;
using System.Data;
using System;

namespace Publicaciones.Domain.Entities
{
    public class Empleoyess : Person
    {
        public char emp_id { get; set; }
        public string fname { get; set; }
        public char? minit { get; set; }
        public string Iname { get; set; }
        public short job_id { get; set; }
        public byte? job_IvI { get; set; }
        public char pub_id { get; set; }
        public DateTime hire_date { get; set; }



    }
}
