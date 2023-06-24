
namespace Publicaciones.Application.Core
{
    public interface IBaseService<TDtoAdd, TDtoMod, TDtoRem>
    {
        ServiceResult Get();
        ServiceResult GetByau_id(string au_id);
        ServiceResult Save(TDtoAdd model);
        ServiceResult Update(TDtoMod model);
        ServiceResult Remove(TDtoRem model);
    }
}
