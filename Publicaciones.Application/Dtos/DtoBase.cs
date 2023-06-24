using System;
using System.Collections.Generic;
using System.Text;

namespace Publicaciones.Application.Dtos
{

    public abstract class DtoBase
    {
        public DateTime ChangeDate { get; set; }
        public int ChangeUser { get; set; }

    }
}