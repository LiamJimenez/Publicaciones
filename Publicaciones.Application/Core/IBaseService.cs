
namespace Publicaciones.Application.Core
{
    public interface IBaseService<TDtoAdd, TDtoMod, TDtoRem>
    {
        ServiceResult Get();
        ServiceResult GetByemp_id(string emp_id);
        ServiceResult GetByjob_id(string job_id);
        ServiceResult Save(TDtoAdd model);
        ServiceResult Update(TDtoMod model);
        ServiceResult Remove(TDtoRem model);
    }
}