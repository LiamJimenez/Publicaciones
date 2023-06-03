using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Publicaciones.Domain.Repository
{
    internal class PublishesDa : IBaseRepository<PublishesDa>
    {
        public bool Exists(Expression<Func<PublishesDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PublishesDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public PublishesDa GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(PublishesDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(PublishesDa entity)
        {
            throw new NotImplementedException();
        }

        public void Save(PublishesDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(PublishesDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
