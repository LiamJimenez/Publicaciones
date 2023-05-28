using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Publicaciones.Infraestructure.Repositories
{
    public class AuthorsDa : IBaseRepository<AuthorsDa>
    {
        bool IBaseRepository<AuthorsDa>.Exists(Expression<Func<AuthorsDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        IEnumerable<AuthorsDa> IBaseRepository<AuthorsDa>.GetEntities()
        {
            throw new NotImplementedException();
        }

        AuthorsDa IBaseRepository<AuthorsDa>.GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<AuthorsDa>.Remove(AuthorsDa entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<AuthorsDa>.Save(AuthorsDa entity)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<AuthorsDa>.Save(AuthorsDa[] entities)
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<AuthorsDa>.Update(AuthorsDa entity)
        {
            throw new NotImplementedException();
        }
    }
}
