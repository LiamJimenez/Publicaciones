using Microsoft.EntityFrameworkCore;
using Publicaciones.Infraestructure.Context;
using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Text;

namespace Publicaciones.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly PublicacionesContext publicaciones;
        private readonly DbSet<TEntity> entities;

        public BaseRepository(PublicacionesContext publicaciones)
        {
            this.publicaciones = publicaciones;
            this.entities = this.publicaciones.Set<TEntity>();
        }
        public virtual bool Exists(Expression<Func<TEntity, bool>> filter)
        {
            return this.entities.Any(filter);
        }
        public virtual List<TEntity> GetEntities()
        {
            return this.entities.ToList();
        }
        public virtual TEntity GetEntity(string au_id)
        {
            return this.entities.Find(au_id);
        }
        public virtual void Remove(TEntity entity)
        {
            this.entities.Remove(entity);

        }
        public virtual void Remove(TEntity[] entities)
        {
            this.entities.RemoveRange(entities);
        }
        public virtual void Add(TEntity entity)
        {
            this.entities.Add(entity);
        }
        public virtual void Add(TEntity[] entities)
        {
            this.entities.AddRange(entities);
        }
        public virtual void Update(TEntity entity)
        {
            this.entities.Update(entity);
        }
        public virtual void Update(TEntity[] entities)
        {
            this.entities.UpdateRange(entities);
        }
        public virtual void SaveChanges()
        {
            this.publicaciones.SaveChanges();
        }

        //public TEntity GetEntity(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}