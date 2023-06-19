﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Publicaciones.Infraestructure.Models
{
    public class AuthorsModel
    {

        [Key]
        public string au_id { get; set; }
        public string? au_lname { get; set; }
        public string? au_fname { get; set; }
        public string? phone { get; set; }
        public string address { get; set; }
        public string? city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public bool? contract { get; set; }
        public string creationuser { get; set; }
        public string creationdate { get; set; }


    }
}
