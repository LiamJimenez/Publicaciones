using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using Publicaciones.Infraestructure.Repositories;

namespace Publicaciones.Domain.Repository
{
    public class titleauthorDa : IBaseRepository<titleauthorDa>
    {
        bool IBaseRepository<titleauthorDa>.Exists(Expression<Func<titleauthorDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IEnumerable<titleauthorDa> IBaseRepository<titleauthorDa>.GetEntities()
        {
            throw new NotImplementedException();
        }

        titleauthorDa IBaseRepository<titleauthorDa>.GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<titleauthorDa>.Remove(titleauthorDa entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<titleauthorDa>.Save(titleauthorDa entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<titleauthorDa>.Save(titleauthorDa[] entities)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<titleauthorDa>.Update(titleauthorDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
