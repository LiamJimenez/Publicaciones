using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Publicaciones.Infraestructure.Repositories
{
    internal class JobsDa : IBaseRepository<JobsDa>
    {
        public bool Exists(Expression<Func<JobsDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JobsDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public JobsDa GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(JobsDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(JobsDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(JobsDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(JobsDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
