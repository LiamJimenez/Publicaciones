using Microsoft.Extensions.Logging;
using Publicaciones.Application.Contract;
using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Employees;
using Publicaciones.Application.Extentions;
using Publicaciones.Domain.Entities;
using Publicaciones.Infraestructure.Exceptions;
using Publicaciones.Infraestructure.Interface;
using System;

namespace Publicaciones.Application.Service
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IEmployeesRepository employeesRepository;
        private readonly ILogger<EmployeesService> logger;

        public EmployeesService(IEmployeesRepository employeesRepository,
                                  ILogger<EmployeesService> logger)
        {
            this.employeesRepository = employeesRepository;
            this.logger = logger;
        }

        public ServiceResult Get()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.employeesRepository.GetEmployees();
            }
            catch (EmployeesException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los deparmentos";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetByemp_id(string emp_id)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                result.Data = this.employeesRepository.GetEmployeesByemp_id(emp_id);
            }
            catch (EmployeesException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error obteniendo los Autores";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult Remove(EmployeesRemoveDto model)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                this.employeesRepository.Remove(new Employees()
                {
                    emp_id = model.emp_id,
                    deleted = model.deleted,
                    deleteddate = model.ChangeDate,
                    userdeleted = model.ChangeUser
                });

                result.Message = "Empleado eliminado correctamente.";

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el departamento.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Save(EmployeesAddDto model)
        {
            ServiceResult result = new ServiceResult();

            if (!model.IsValidAuthors().Success)
                return result;


            try
            {
                var employees = model.ConvertDtoAddToEntity();

                this.employeesRepository.Add(employees);

                result.Message = "Empleado agregado correctamente.";
            }
            catch (EmployeesException dex)
            {
                result.Success = false;
                result.Message = dex.Message;
                this.logger.LogError($"{result.Message}");

            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error guardando el Empleado.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public ServiceResult Update(EmployeesUpdateDto model)
        {
            ServiceResult result = new ServiceResult();

            if (!model.IsValidAuthors().Success)
                return result;

            try
            {
                var employees = model.ConvertDtoUpdateToEntity();

                this.employeesRepository.Update(employees);

                result.Message = "Empleado actualizado correctamente.";
            }
            catch (Exception ex)
            {

                result.Success = false;
                result.Message = "Error actualizando el empleado.";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }



            return result;
        }
    }
}

