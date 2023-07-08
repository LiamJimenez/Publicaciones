
using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;

namespace Publicaciones.Application.Contract
{

    public interface IEmployeesService : IBaseService<EmployeesAddDto, EmployeesUpdateDto, EmployeesRemoveDto>
    {

    }
}