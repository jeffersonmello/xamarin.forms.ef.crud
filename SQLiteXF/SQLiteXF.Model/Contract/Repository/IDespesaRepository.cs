using SQLiteXF.Model.Data.Financeiro;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLiteXF.Model.Contract.Repository
{
    public interface IDespesaRepository
    {
        Task<List<Despesa>> GetAllAsync();

        Task<Despesa> GetAsync();

        Task<Despesa> SaveAsync(Despesa despesa);

        Task<Despesa> UpdateAsync(Despesa despesa);

        Task<bool> Delete(int Id);

        Task<List<Despesa>> QueryAsync(Func<Despesa, bool> predicate);
    }
}
