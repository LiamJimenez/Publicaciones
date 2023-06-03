using Publicaciones.Infraestructure.Repositories;
using Publicaciones.Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Publicaciones.Domain.Repository
{
    internal class EmpleoyessDa : IBaseRepository<EmpleoyessDa>
    {
        public bool Exists(Expression<Func<EmpleoyessDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmpleoyessDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public EmpleoyessDa GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(EmpleoyessDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(EmpleoyessDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(EmpleoyessDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(EmpleoyessDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
