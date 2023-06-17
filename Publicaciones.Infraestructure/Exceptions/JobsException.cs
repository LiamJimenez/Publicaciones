using System;
using System.Collections.Generic;

namespace Publicaciones.Infraestructure.Exceptions
{
    public class JobsException : Exception
    {
        public JobsException(string message) : base(message)
        {
        }
    }
}