using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Domain.Entities;
using Publicaciones.Domain.Repositories;
using System.Collections.Generic;
using Publicaciones.Infraestructure.Models;
using System;

namespace Publicaciones.Infraestructure.Interface
{
    public interface IEmployeesRepository
    {
        List<EmployeesModel> GetEmployees();
        EmployeesModel GetEmployeesByemp_id(int id);
    }

}