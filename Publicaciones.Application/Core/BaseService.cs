

namespace Publicaciones.Application.Core
{
    public abstract class BaseService<TModelAdd, TModelMod, TModelRem>
    {
        public abstract ServiceResult Get();
        public abstract ServiceResult GetByau_id(string au_id);
        public abstract ServiceResult Save(TModelAdd model);
        public abstract ServiceResult Update(TModelMod model);
        public abstract ServiceResult Remove(TModelRem model);

    }
}
