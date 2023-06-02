﻿using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Publicaciones.Infraestructure.Core
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        public bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetEntities()
        {
            throw new NotImplementedException();
        }

        public TEntity GetEntity(int entityid)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Save(TEntity[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
