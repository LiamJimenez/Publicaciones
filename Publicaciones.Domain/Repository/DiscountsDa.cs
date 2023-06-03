using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Publicaciones.Infraestructure.Repository
{
    public class DiscountsDa : IBaseRepository<DiscountsDa>
    {
        public bool Exists(Expression<Func<DiscountsDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DiscountsDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public DiscountsDa GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(DiscountsDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(DiscountsDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(DiscountsDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(DiscountsDa entity)
        {
            throw new NotImplementedException();
        }
    }
}