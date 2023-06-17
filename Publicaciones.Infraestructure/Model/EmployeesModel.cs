using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Publicaciones.Infraestructure.Models
{
    public class EmployeesModel
    {
        [Key]
        public char emp_id { get; set; }
        public string fname { get; set; }
        public char? minit { get; set; }
        public string lname { get; set; }
        public short job_id { get; set; }
        public byte? job_lvl { get; set; }
        public char pub_id { get; set; }
        public DateTime hire_date { get; set; }
    }
}