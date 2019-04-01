using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OmegaInc.Repository.Contract
{
    /// <summary>
    /// Interface para repositorio Assincrono
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface IGenericAsyncRepository<TEntity, TKey>
    {
        Task<List<TEntity>> GetAllAsync();

        Task<TEntity> GetAsync(TKey Id);

        Task<TEntity> SaveAsync(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<bool> Delete(TKey Id);

        Task<List<TEntity>> QueryAsync(Func<TEntity, bool> predicate);
    }
}
