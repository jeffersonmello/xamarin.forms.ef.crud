using Microsoft.EntityFrameworkCore;
using OmegaInc.Repository.Contract;
using SQLiteXF.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OmegaInc.RepositoryEntity.Abstract
{
    /// <summary>
    /// Abstração para rpositorio comum
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public abstract class RepositoryEntityBase<TEntity, TKey> : IGenericRepository<TEntity, TKey>
          where TEntity : class
    {
        protected DbContext _context;

        public RepositoryEntityBase(string dbPath)
        {
            _context = new DataContext(dbPath);
        }

        public virtual void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void DeleteById(TKey id)
        {
            TEntity entity = SelectById(id);
            Delete(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _context.Set<TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public virtual void Save(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public virtual List<TEntity> Select()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity SelectById(TKey id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual List<TEntity> Query(Func<TEntity, bool> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }
    }
}
