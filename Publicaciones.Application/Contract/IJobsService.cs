
using Publicaciones.Application.Core;
using Publicaciones.Application.Dtos.Authors;

namespace Publicaciones.Application.Contract
{

    public interface IJobsService : IBaseService<JobsAddDto, JobsUpdateDto, JobsRemoveDto>
    {

    }
}