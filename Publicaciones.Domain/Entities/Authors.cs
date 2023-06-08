using System;
using Publicaciones.Domain.Core;

namespace Publicaciones.Domain.Entities
{
    public class Authors : Person 
    {
        public string? au_id {  get; set; }
        public string? au_Iname { get; set; }
        public string? au_fname { get; set;}

        public string address { get; set;}
        public string city { get; set;}
        public char state { get; set;}
        public char zip { get; set;}
        public byte contract { get; set;}

    }
}
