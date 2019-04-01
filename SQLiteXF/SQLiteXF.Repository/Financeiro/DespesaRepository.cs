using SQLiteXF.Model.Data.Financeiro;
using SQLiteXF.Repository.Abstract;

namespace SQLiteXF.Repository.Financeiro
{
    /// <summary>
    /// Repositorio de despesas
    /// </summary>
    public class DespesaRepository : RepositoryBase<Despesa, int>
    {
        public DespesaRepository(string dbPath)
            : base(dbPath)
        {
        }
    }
}
