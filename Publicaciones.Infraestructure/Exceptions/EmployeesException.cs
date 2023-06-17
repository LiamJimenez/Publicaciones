using System;
using System.Collections.Generic;

namespace Publicaciones.Infraestructure.Exceptions
{
    public class EmployeesException : Exception
    {
        public EmployeesException(string message) : base(message)
        {
        }
    }
}
