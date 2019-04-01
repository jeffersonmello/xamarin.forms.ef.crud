using OmegaInc.RepositoryEntity.Abstract;

namespace SQLiteXF.Repository.Abstract
{
    /// <summary>
    /// Abstração para repositorio
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public abstract class RepositoryBase<TEntity, TKey> : RepositoryEntityBase<TEntity, TKey>
        where TEntity : class
    {
        public RepositoryBase(string dbPath)
            : base(dbPath)
        {
        }
    }
}
