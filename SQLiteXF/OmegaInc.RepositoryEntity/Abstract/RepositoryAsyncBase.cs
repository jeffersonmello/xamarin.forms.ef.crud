using Microsoft.EntityFrameworkCore;
using OmegaInc.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OmegaInc.RepositoryEntity.Abstract
{
    /// <summary>
    /// Abstração de repositorio Assincrono
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public abstract class RepositoryAsyncBase<TEntity, TKey> /*: IGenericAsyncRepository<TEntity, TKey>*/
        //where TEntity : class
    {
        //protected DbContext _context;

        //public RepositoryAsyncBase(DbContext context)
        //{
        //    _context = context;
        //}

        //public virtual Task<List<TEntity>> GetAllAsync()
        //{
           
        //}

        //public virtual Task<TEntity> GetAsync(TKey Id)
        //{

        //}

        //public virtual Task<TEntity> SaveAsync(TEntity entity)
        //{

        //}

        //public virtual Task<TEntity> UpdateAsync(TEntity entity)
        //{

        //}

        //public virtual Task<bool> Delete(TKey Id)
        //{

        //}

        //public virtual Task<List<TEntity>> QueryAsync(Func<TEntity, bool> predicate)
        //{

        //}
    }
}
