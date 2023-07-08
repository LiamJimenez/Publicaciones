using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;
using Publicaciones.Domain.Entities;


namespace Publicaciones.Application.Extentions
{
    public static class EmployeesAppExtention
    {

        public static Employees ConvertDtoAddToEntity(this EmployeesAddDto employeesAddDto)
        {
            return new Employees()
            {

                emp_id = employeesAddDto.emp_id,
                emp_fname = employeesAddDto.emp_fname,
                emp_lname = employeesAddDto.emp_lname,
                minit = employeesAddDto.minit,
                job_id = employeesAddDto.job_id,
                job_lvl = employeesAddDto.job_lvl,
                pub_id = employeesAddDto.pub_id,
                hire_date = employeesAddDto.hire_date,
                modifydate = authorsAddDto.ChangeDate,
                creationdate = authorsAddDto.ChangeDate,
                creationuser = authorsAddDto.ChangeUser

            };
        }

        public static Employees ConvertDtoUpdateToEntity(this EmployeesUpdateDto employeesUpdateDto)
        {
            return new Employees()
            {

                emp_id = employeesAddDto.emp_id,
                emp_fname = employeesAddDto.emp_fname,
                emp_lname = employeesAddDto.emp_lname,
                minit = employeesAddDto.minit,
                job_id = employeesAddDto.job_id,
                job_lvl = employeesAddDto.job_lvl,
                pub_id = employeesAddDto.pub_id,
                hire_date = employeesAddDto.hire_date,
                modifydate = authorsAddDto.ChangeDate,
                creationdate = authorsAddDto.ChangeDate,
                creationuser = authorsAddDto.ChangeUser

            };
        }

        public static ServiceResult IsValidAuthors(this EmployeesDto model)
        {
            ServiceResult result = new ServiceResult();

            if (string.IsNullOrEmpty(model.emp_id))
            {
                result.Message = "El id del empleado es requerido.";
                result.Success = false;
                return result;
            }

            if (model.emp_id.Length > 50)
            {
                result.Message = "El id del empleado tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.emp_fname))
            {
                result.Message = "El nombre del empleado es requerido.";
                result.Success = false;
                return result;
            }

            if (model.emp_fname.Length > 50)
            {
                result.Message = "El nombre del empleado tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.emp_lname))
            {
                result.Message = "El apellido del empleado es requerido.";
                result.Success = false;
                return result;
            }

            if (model.emp_lname.Length > 50)
            {
                result.Message = "El apellido del empleado tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.minit))
            {
                result.Message = "El minit del empleado es requerido.";
                result.Success = false;
                return result;
            }

            if (model.minit.Length > 50)
            {
                result.Message = "El minit del autor tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.job_id))
            {
                result.Message = "El Job ID del Empleado es requerido.";
                result.Success = false;
                return result;
            }

            if (model.job_id.Length > 50)
            {
                result.Message = "El Job ID del empleado tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.job_lvl))
            {
                result.Message = "El job_lvl del empleado es requerido.";
                result.Success = false;
                return result;
            }

            if (model.job_lvl.Length > 50)
            {
                result.Message = "El job_lvl del empleado tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            if (string.IsNullOrEmpty(model.pub_id))
            {
                result.Message = "El pub_id del empleado es requerido.";
                result.Success = false;
                return result;
            }

            if (model.pub_id.Length > 50)
            {
                result.Message = "El pub_id del empleado tiene la logitud invalida.";
                result.Success = false;
                return result;
            }

            return result;
        }
    }
}

