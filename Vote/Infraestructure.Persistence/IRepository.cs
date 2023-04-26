using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence.Repository.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
    }
}