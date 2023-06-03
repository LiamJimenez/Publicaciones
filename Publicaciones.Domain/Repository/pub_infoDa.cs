using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Publicaciones.Domain.Repository
{
    internal class pub_infoDa : IBaseRepository<pub_infoDa>
    {
        public bool Exists(Expression<Func<pub_infoDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<pub_infoDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public pub_infoDa GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(pub_infoDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(pub_infoDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(pub_infoDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(pub_infoDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
