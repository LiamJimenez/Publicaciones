using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Publicaciones.Infraestructure.Repository
{
    internal class SalesDa : IBaseRepository<SalesDa>
    {
        public bool Exists(Expression<Func<SalesDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public SalesDa GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(SalesDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(SalesDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(SalesDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(SalesDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
