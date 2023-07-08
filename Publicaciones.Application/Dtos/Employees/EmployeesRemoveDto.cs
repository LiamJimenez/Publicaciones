
namespace Publicaciones.Application.Dtos.Employees
{
    public class EmployeesRemoveDto : DtoBase
    {
        public string emp_id { get; set; }
        public bool deleted { get; set; }
    }
}