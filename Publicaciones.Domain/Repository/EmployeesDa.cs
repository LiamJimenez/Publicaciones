using Publicaciones.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Publicaciones.Domain.Repository
{
    public class EmployeesDa : IBaseRepository<EmployeesDa>
    {
        public void Add(EmployeesDa entity)
        {
            throw new NotImplementedException();
        }

        public void Add(EmployeesDa[] entities)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Expression<Func<EmployeesDa, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<EmployeesDa> GetEntities()
        {
            throw new NotImplementedException();
        }

        public EmployeesDa GetEntity(string au_id)
        {
            throw new NotImplementedException();
        }

        public void Remove(EmployeesDa entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(EmployeesDa[] entities)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(EmployeesDa entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EmployeesDa[] entities)
        {
            throw new NotImplementedException();
        }
    }
}