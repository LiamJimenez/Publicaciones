using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Publicaciones.Domain.Repository
{
    internal class publicInfoDa : IBaseRepository<publicInfoDa>
    {
        public bool Exists(Expression<Func<publicInfoDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<publicInfoDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public publicInfoDa GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(publicInfoDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(publicInfoDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(publicInfoDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(publicInfoDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
