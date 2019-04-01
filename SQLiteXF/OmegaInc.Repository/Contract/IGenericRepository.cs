using System;
using System.Collections.Generic;

namespace OmegaInc.Repository.Contract
{
    /// <summary>
    /// Interface para repositorio comum
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface IGenericRepository<TEntity, TKey>
    {
        List<TEntity> Select();
        TEntity SelectById(TKey id);        
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteById(TKey id);
        List<TEntity> Query(Func<TEntity, bool> predicate);
    }
}
